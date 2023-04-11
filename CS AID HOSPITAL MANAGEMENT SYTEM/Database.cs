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

        private static string DoctorListFileName = "DoctorRecords.csaid";
        private static string PatientsListFileName = "PatientRecords.csaid";

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
            // Masterlist.AddRange(Admin);

            return Masterlist;
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
            string encryptedContents = File.ReadAllText(DoctorListFileName);
            string decryptedContents = encryptDecrypt(encryptedContents);

            Doctors = JsonConvert.DeserializeObject<List<Doctor>>(decryptedContents);
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

            /*var nurseListQuery = service.Files.List();
            nurseListQuery.Q = $"name = '{"NurseRecord.csaid"}' and '{directoryID}' in parents";
            var nurseList = nurseListQuery.Execute();*/

            // Clear all errors first

            if (doctorList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the doctor records masterlist");

            if (patientList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the patient records masterlist");

            /*if(nurseList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the nurse records masterlist");*/

            // Then load database if no errors

            DownloadDoctorList();
            DeserializeDoctors();

            // DownloadPatientList();
            // DeserializePatients();

            // ...
        }
    }
}
