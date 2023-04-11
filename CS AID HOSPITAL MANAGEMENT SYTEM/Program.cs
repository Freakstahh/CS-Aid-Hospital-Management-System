using CS_Aid_Hospital_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        // Database.InitializeDatabase();

        Database.Doctors.Clear();
        Database.SerializeDoctors();
        Database.UploadDoctorList();

        Database.Admins.Clear();
        
        Admin dan = new Admin("Dan", "M", DateTime.Now, 123, "@gmail.com", "freakstahhh", "nursing123", "Mornight", "Pag-Ibig", "00-01", "00");

        Database.Admins.Add(dan);

        Database.SerializeAdmins();
        Database.UploadAdminList();
        

        /*// wala pa, mag himo pa ug account padung
        // pag butang pud mo ug checkbox nga "show password"
        Patient salem = new Patient("Cye", "Salem", "Michael", "Aladdin", 132, 0, -1, 12, DateTime.Now, DateTime.Now);
        Doctor wakwak = new Doctor("Vicky", "Male", DateTime.Now, 123, "@gmail.com", "darkstar69", "sheeesh", "123", "Mornight", "Philhealth", "Bugos");

        wakwak.Patients.Add(salem);

        Database.Doctors.Add(wakwak);

        Database.SerializeDoctors();
        Database.UploadDoctorList();*/
    }
}