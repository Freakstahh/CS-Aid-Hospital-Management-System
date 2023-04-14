using CS_Aid_Hospital_Management_System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using System.IO;
using System.Net.Http;
using Google.Apis.Util.Store;
using System.Windows.Documents;

namespace CSAid_MainWinFormsApp.View
{
    public partial class Admin_addPatient : UserControl
    {
        public Admin_addPatient()
        {
            InitializeComponent();
        }


        private void Admin_addPatient_Load(object sender, EventArgs e)
        {
            Database.DownloadPatientsList();
            Database.DeserializePatients();

            patDataList.DataSource = Database.Patients;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string patIDInput = patID.Text;
            string roomNumInput = roomNum.Text;
            string floorNumInput = floorNum.Text;
            if (int.TryParse(patIDInput, out int patIDInt) && int.TryParse(roomNumInput, out int roomNumInt) && int.TryParse(floorNumInput, out int floorNumInt))
            {
                Patient patient = new Patient(lastName.Text, firstName.Text, midName.Text, diag.Text, patIDInt, roomNumInt, floorNumInt, admitDate.Value, birthDatePicker.Value);
                Database.Patients.Add(patient);
                Database.SerializePatients();
                Database.UploadPatientList();
                MessageBox.Show("Data successfully added to database.");
            }
            else
            {
                // The input string is not a valid integer. Display an error message.
                MessageBox.Show("Parsing failed. The input string is not a valid integer. Failed to upload to database.");
            }
        }
    }
}
