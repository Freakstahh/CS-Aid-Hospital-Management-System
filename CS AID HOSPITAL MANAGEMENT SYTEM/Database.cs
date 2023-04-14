using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Drive.v3;
using Google.Apis.Auth.OAuth2;
using CS_Aid_Hospital_Management_System.Properties;
using Google.Apis.Services;
using Google.Apis.Download;

namespace CS_Aid_Hospital_Management_System
{
    public class Database
    {
        private static string downloadPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string directoryID = "1oFy8i7BfWmFEONvkpXXbeekm4Hsir9qV";

        private static string DoctorListGoogleDriveFileID = "1c8V5hXlDIKk_tctO3itfnqYkYy-U_cBu";
        private static string PatientsListGoogleDriveFileID = "1zCA1TmCeYh3w2Q9VO-73UKyEL3zXIKxY";
        private static string AdminListGoogleDriveFileID = "1I7tmrx3RQOqKWOmzCvn42Tnis66g0NVk";
        private static string RoomsListGoogleDriveFileID = "1YfJqHAMbfUl17xdujS1OnCTPIH-QYZsI";
        private static string NurseListGoogleDriveFileID = "15GBJ4kRf_7rhcmRSLyp1MpA8--74M5Xa";
        private static string ItemListGoogleDriveFileID = "1dp4OBfjSqNwsLFNJMV2RiAXB8SUtRp0r";

        private static string DoctorListFileName = "DoctorRecords.csaid";
        private static string PatientsListFileName = "PatientRecords.csaid";
        private static string AdminListFileName = "AdminRecords.csaid";
        private static string RoomsListFileName = "RoomsRecords.csaid";
        private static string NurseListFileName = "NurseRecords.csaid";
        private static string ItemListFileName = "ItemRecords.csaid";


        private static string keyword = "health123";

        public static List<Doctor> Doctors = new List<Doctor>();
        public static List<Patient> Patients = new List<Patient>();
        public static List<Nurse> Nurse = new List<Nurse>();
        public static List<Admin> Admins = new List<Admin>();
        public static List<Item> Items = new List<Item>();
        public static List<Room> Rooms = new List<Room>();

        public static List<User> Masterlist()
        {
            List<User> Masterlist = new List<User>();
            Masterlist.AddRange(Doctors);
            // Masterlist.AddRange(Nurse);
            Masterlist.AddRange(Admins);

            return Masterlist;
        }

        public static List<Patient> PatientList()
        {
            List<Patient> PatientList = new List<Patient>();
            PatientList.AddRange(Patients);
            return PatientList;
        }
        public static List<Item> ItemList()
        {
            List<Item> ItemList = new List<Item>();
            ItemList.AddRange(Items);
            return ItemList;
        }

        #region Doctors List Serialization and Deserialization
        public static void SerializeDoctors()
        {
            string contents = JsonConvert.SerializeObject(Doctors);
            contents = encryptDecrypt(contents);
            File.WriteAllText(DoctorListFileName, contents);
        }

        public static void DeserializeDoctors()
        {
            string encryptedContents = File.ReadAllText(Path.Combine(downloadPath, DoctorListFileName));
            string decryptedContents = encryptDecrypt(encryptedContents);

            Doctors = JsonConvert.DeserializeObject<List<Doctor>>(decryptedContents);
        }

        #endregion

        #region Admin List Serialization and Deserialization
        public static void SerializeAdmins()
        {
            string contents = JsonConvert.SerializeObject(Admins);
            contents = encryptDecrypt(contents);
            File.WriteAllText(AdminListFileName, contents);
        }

        public static void DeserializeAdmins()
        {
            string encryptedContents = File.ReadAllText(AdminListFileName);
            string decryptedContents = encryptDecrypt(encryptedContents);

            Admins = JsonConvert.DeserializeObject<List<Admin>>(decryptedContents);
        }

        #endregion

        #region Item List Serialization and Deserialization
        public static void SerializeItems()
        {
            string contents = JsonConvert.SerializeObject(Items);
            contents = encryptDecrypt(contents);
            File.WriteAllText(ItemListFileName, contents);
        }

        public static void DeserializeItems()
        {
            string encryptedContents = File.ReadAllText(ItemListFileName);
            string decryptedContents = encryptDecrypt(encryptedContents);

            Items = JsonConvert.DeserializeObject<List<Item>>(decryptedContents);
        }

        #endregion

        #region Nurse List Serialization and Deserialization
        public static void SerializeNurse()
        {
            string contents = JsonConvert.SerializeObject(Nurse);
            contents = encryptDecrypt(contents);
            File.WriteAllText(NurseListFileName, contents);
        }

        public static void DeserializeNurse()
        {
            string encryptedContents = File.ReadAllText(NurseListFileName);
            string decryptedContents = encryptDecrypt(encryptedContents);

            Nurse = JsonConvert.DeserializeObject<List<Nurse>>(decryptedContents);
        }

        #endregion

        #region Patient List Serialization and Deserialization
        public static void SerializePatients()
        {
            string contents = JsonConvert.SerializeObject(Patients);
            contents = encryptDecrypt(contents);
            File.WriteAllText(PatientsListFileName, contents);
        }

        public static void DeserializePatients()
        {
            string encryptedContents = File.ReadAllText(PatientsListFileName);
            string decryptedContents = encryptDecrypt(encryptedContents);

            Patients = JsonConvert.DeserializeObject<List<Patient>>(decryptedContents);
        }

        #endregion

        #region Rooms List Serialization and Deserialization
        public static void SerializeRooms()
        {
            string contents = JsonConvert.SerializeObject(Rooms);
            contents = encryptDecrypt(contents);
            File.WriteAllText(RoomsListFileName, contents);
        }

        public static void DeserializeRooms()
        {
            string encryptedContents = File.ReadAllText(RoomsListFileName);
            string decryptedContents = encryptDecrypt(encryptedContents);

            Rooms = JsonConvert.DeserializeObject<List<Room>>(decryptedContents);
        }

        #endregion

        public static void UploadDoctorList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = DoctorListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(DoctorListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, DoctorListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(DoctorListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void UploadAdminList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = AdminListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(AdminListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, AdminListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(AdminListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void UploadNurseList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = NurseListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(NurseListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, NurseListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(AdminListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void UploadPatientList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = PatientsListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(PatientsListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, PatientsListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(PatientsListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void UploadItemList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = ItemListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(ItemListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, ItemListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(ItemListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void UploadRoomList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = RoomsListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(RoomsListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, RoomsListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(RoomsListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadDoctorList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(DoctorListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, DoctorListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadAdminList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(AdminListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, AdminListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadNurseList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(NurseListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, DoctorListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadPatientsList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(PatientsListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, PatientsListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadItemList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(ItemListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, ItemListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadRoomsList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(RoomsListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, DoctorListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void CreateFileToGoogleDrive()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = DoctorListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<string>() { directoryID }
                };

                using (var stream = new FileStream(DoctorListFileName, FileMode.OpenOrCreate))
                {
                    var request = service.Files.Create(fileMetadata, stream, "text/plain");
                    request.Fields = "id";
                    request.Upload();

                    Console.WriteLine(request.ResponseBody.Id);
                };
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        private static string encryptDecrypt(string data)
        {
            string result = "";

            for (int i = 0; i < data.Length; i++)
            {
                result += (char)(data[i] ^ Database.keyword[i % Database.keyword.Length]);
            }

            return result;
        }

        public static void InitializeDatabase()
        {
            var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.CSAidServiceKey)).CreateScoped(DriveService.Scope.Drive);

            var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Snippets"
            });

            var doctorListQuery = service.Files.List();
            doctorListQuery.Q = $"name = '{DoctorListFileName}' and '{directoryID}' in parents";
            var doctorList = doctorListQuery.Execute();

            var patientListQuery = service.Files.List();
            patientListQuery.Q = $"name = '{PatientsListFileName}' and '{directoryID}' in parents";
            var patientList = patientListQuery.Execute();

            var adminListQuery = service.Files.List();
            adminListQuery.Q = $"name = '{AdminListFileName}' and '{directoryID}' in parents";
            var adminList = adminListQuery.Execute();

            var itemListQuery = service.Files.List();
            itemListQuery.Q = $"name = '{ItemListFileName}' and '{directoryID}' in parents";
            var itemList = itemListQuery.Execute();

            /*var nurseListQuery = service.Files.List();
            nurseListQuery.Q = $"name = '{"NurseRecord.csaid"}' and '{directoryID}' in parents";
            var nurseList = nurseListQuery.Execute();*/

            // Clear all errors first

            if (doctorList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the doctor records masterlist");

            if (patientList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the patient records masterlist");

            if (adminList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the patient records masterlist");

            if (itemList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the patient records masterlist");

            /*if(nurseList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the nurse records masterlist");*/

            // Then load database if no errors

            DownloadDoctorList();
            DeserializeDoctors();

            DownloadAdminList();
            DeserializeAdmins();

            DownloadPatientsList();
            DeserializePatients();

            DownloadItemList();
            DeserializeItems();
            // ...
        }
    }
}