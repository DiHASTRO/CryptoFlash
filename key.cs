using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.IO.Compression;


namespace Flash_key
{
    class Cryptor
    {
        private const int size16mb = 16777216;

        // ключ диска вычисляется по sha256 из строки: drive.TotalSize + drive.DriveType + drive.DriveFormat + drive.VolumeLabel
        static private string driveKeyHash = "56-2A-BD-96-18-8F-31-ED-1A-F8-4B-6B-F6-FE-85-8E-31-68-CF-90-D1-8B-FB-74-9F-DF-62-AE-98-B1-C1-BC";
        static private string fileKeyHash = "0C-A8-B6-56-83-07-C7-4D-B9-78-2B-2E-AD-C4-2B-04-E8-C2-25-6D-21-47-DD-09-50-75-A7-6B-42-F0-C7-2A";

        // переменные для работы с файловой системой компьютера
        static private DriveInfo[] allDrives;
        static private string path;

        // переменные для работы со свойствами диска (флешки-ключа)
        static string hashStrDrive;
        static byte[] byteHash;
        static byte[] hashDriveEncoded;
        static private string hashDrive;

        // переменные для работы с файлом-ключом
        static private string hashFile;
        static private byte[] hashFileEncoded;
        static private byte[] fileForHashing;

        // переменная, подтверждающая доступ
        static private bool access;

        // 
        static private byte[] bytesArchive;
        static private byte[] buffer = new byte[size16mb];
        static private byte[] lastBuffer;
        static private int fileCount;

        private const string folderName = @"forZipping\";
        private const string encZip = "ForEncrypting.zip";

        static private byte[][] partedZip;

        public static bool CheckKey()
        {
            access = false; // установка стандартного значения доступа
            allDrives = DriveInfo.GetDrives(); // получение массива из дисков

            foreach (DriveInfo drive in allDrives) // перебор всех дисков - потенциально возможных ключей-дисков
            {
                if (drive.DriveType == DriveType.Removable) // проверка, является ли диск съёмным накопителем, чтобы не проверять остальные диски
                {
                    hashStrDrive = drive.TotalSize.ToString() + drive.DriveType + drive.DriveFormat + drive.VolumeLabel; // сбор строки, из которой формируется хэш
                    byteHash = Encoding.UTF8.GetBytes(hashStrDrive); // перевод строки в байтовый вид для последующего хэширования
                    hashDriveEncoded = SHA256.Create().ComputeHash(byteHash); // хэширование строки посредством создания шифратора статическим методом класса SHA256 - Create. Далее вычисление хэша ComputeHash
                    hashDrive = BitConverter.ToString(hashDriveEncoded); // перевод хэша в 16-ричную систему счисления - строку
                    if (hashDrive == driveKeyHash)  // проверка полученного хэша на совпадение с имеющимся ключом диска
                    {
                        path = $@"{drive.Name}"; // прописывание пути к флешке-ключу
                        foreach (string currentFile in Directory.EnumerateFiles(path, "*.png")) // перебор всех файлов - потенциальных ключей-файлов // так как есть огромные файлы, сокращаем поиск по .png (со знанием того, что наш ключ имеет именно это расширение)
                        {
                            fileForHashing = File.ReadAllBytes(currentFile); // открытие файла сразу в битовом формате для последующего хэширования
                            hashFileEncoded = SHA256.Create().ComputeHash(fileForHashing); // хэширование набора битов из файла аналогично хэшированию набора битов диска (флэшки-ключа)
                            hashFile = BitConverter.ToString(hashFileEncoded); // перевод хэша в 16-ричную систему счисления - сторку

                            if (hashFile == fileKeyHash) // проверка полученного хэша на совпадение с имеющимся ключом файла
                            {
                                access = true; // разрешение доступа (присвоение к переменной доступа значения true)
                                break; // досрочное окончание цикла, чтобы бессмысленно не проверять остальные файлы на диске
                            }
                        }
                    }
                    if (access)
                    {
                        break; // досрочное окончание цикла, чтобы бессмысленно не проверять остальные съёмные диски, если они есть
                    }
                }
            }

            return access; // возврат значения доступа
        }

        static public void CycleBias(ref byte[] byteArray, int bias) // bias > 0 - вправо, bias < 0 - влево
        {
            // if (bias < 0) throw new ArgumentException(nameof(bias));

            int n = byteArray.Length;
            bias %= n;

            if (bias >= 0)
            {
                Array.Reverse(byteArray);
                Array.Reverse(byteArray, 0, bias);
                Array.Reverse(byteArray, bias, n - bias);
            }
            else
            {
                bias = Math.Abs(bias);
                Array.Reverse(byteArray);
                Array.Reverse(byteArray, 0, n - bias);
                Array.Reverse(byteArray, n - bias, bias);

            }
        }

        static public void DeleteDirectory(string path)
        {
            DirectoryInfo currentDir = new DirectoryInfo(path);
            currentDir.Attributes = currentDir.Attributes & ~FileAttributes.ReadOnly;
            foreach (string directoryName in Directory.GetDirectories(path))
            {
                DirectoryInfo dir = new DirectoryInfo(directoryName);
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                DeleteDirectory(directoryName);
            }

            foreach (string file in Directory.EnumerateFiles(path))
            {
                File.Delete(file);
            }

            Directory.Delete(path);
        }

        static public void Encrypt(string driveName)
        {
            if (driveName == @"c:\" || driveName == @"d:\")
            {
                throw new CryptographicException("You cannot encrypt system drive");
            }

            Directory.CreateDirectory($@"{driveName}{folderName}");

            foreach (string name in Directory.EnumerateFiles(driveName))
            {
                string filename = name.Substring(driveName.Length);
                File.Move(name, driveName + folderName + filename);
            }
            foreach (string name in Directory.GetDirectories(driveName))
            {
                string folderPath = driveName + folderName;
                string SVI = driveName + "System Volume Information";
                if (name + @"\" != folderPath && name != SVI)
                {
                    string filename = name.Substring(driveName.Length);
                    Directory.Move(name, driveName + folderName + filename);
                }
            }

            ZipFile.CreateFromDirectory($@"{driveName}{folderName}", encZip);
            bytesArchive = File.ReadAllBytes(encZip);

            CycleBias(ref bytesArchive, bytesArchive.Length / 2);

            if (bytesArchive.Length % size16mb == 0)
            {
                fileCount = bytesArchive.Length / size16mb;
            }
            else
            {
                fileCount = bytesArchive.Length / size16mb + 1;
            }

            for (int number = 0; number < fileCount; number++)
            {
                path = driveName + number.ToString("X");
                if (number != fileCount - 1)
                {
                    Array.Copy(bytesArchive, number * size16mb, buffer, 0, size16mb);

                    File.WriteAllBytes(path, buffer);
                }
                else
                {
                    lastBuffer = new byte[bytesArchive.Length - number * size16mb];
                    Array.Copy(bytesArchive, number * size16mb, lastBuffer, 0, bytesArchive.Length - number * size16mb);

                    File.WriteAllBytes(path, lastBuffer);
                }
            }
            // Console.WriteLine($"Путь: {driveName}{folderName}");
            DeleteDirectory(driveName + folderName);
            File.Delete(encZip);
        }

        static public void Decrypt(string driveName)
        {
            path = driveName + "ForDecrypting.zip";
            int filesCount = 0;
            int count = 0;
            long fileSize = 0;

            foreach (string partName in Directory.EnumerateFiles(driveName))
            {
                filesCount += 1;
            }
            partedZip = new byte[filesCount][];

            foreach (string fileName in Directory.EnumerateFiles(driveName))
            {
                // Console.WriteLine($"Файл {fileName}");
                partedZip[count] = File.ReadAllBytes(fileName);
                File.Delete(fileName);
                fileSize += partedZip[count].Length;
                count += 1;
            }

            bytesArchive = new byte[fileSize];
            // Console.WriteLine($"{nameof(fileCount)} = {fileCount}");
            for (int i = 0; i < filesCount; i++)
            {
                Array.Copy(partedZip[i], 0, bytesArchive, i * size16mb, partedZip[i].Length);
                // Console.WriteLine($"Размер куска {partedZip[i].Length}");
            }

            CycleBias(ref bytesArchive, -bytesArchive.Length / 2);

            // Console.WriteLine(bytesArchive.Length);

            // Console.WriteLine("Извини, архив");
            File.WriteAllBytes(path, bytesArchive);
            ZipFile.ExtractToDirectory(path, driveName);
            File.Delete(path);
        }

        static public string[] GetDrives()
        {
            string[] drives;
            int driveCount = 0;
            allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    driveCount += 1;
                }
            }
            drives = new string[driveCount];

            driveCount = 0;
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    drives[driveCount] = drive.Name;
                    driveCount += 1;
                }
            }
            
            return drives;
        }
    }
}
