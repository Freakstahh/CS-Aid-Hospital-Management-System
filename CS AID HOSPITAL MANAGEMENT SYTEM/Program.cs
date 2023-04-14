using CS_Aid_Hospital_Management_System;

public class Program
{
    public static void Main(string[] args)
    {
        Database.Admins.Clear();
        
        Admin dan = new Admin("00-01", "Dan", "M", DateTime.Now, "123", "@gmail.com", "freakstahhh", "nursing123", "Mornight", "Pag-Ibig", "00");

        Database.Admins.Add(dan);

        Database.SerializeAdmins();
        Database.UploadAdminList();
        
        //For Testing Only, if Unique Key Works
        Database.Doctors.Clear();

        /*Doctor rene = new Doctor("01-01", "Renejay de los Reyes", "M", DateTime.Now, "09229390", "sadmirer289@gmail.com", "MyBickIsDig", "IFoccUreMom", "Heart Surgeon", "MTh-8:00 - 11:00 AM", "Emergency", "01");

        Database.Doctors.Add(rene);*/

        Database.SerializeDoctors();
        Database.UploadDoctorList();

        Database.Patients.Clear();

        /*Doctor rene = new Doctor("01-01", "Renejay de los Reyes", "M", DateTime.Now, "09229390", "sadmirer289@gmail.com", "MyBickIsDig", "IFoccUreMom", "Heart Surgeon", "MTh-8:00 - 11:00 AM", "Emergency", "01");

        Database.Doctors.Add(rene);*/

        Database.SerializePatients();
        Database.UploadPatientList();
    }
}