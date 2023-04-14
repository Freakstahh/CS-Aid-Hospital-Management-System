using CS_Aid_Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAid_MainWinFormsApp.View
{
    public partial class Admin_Inventory : UserControl
    {
        public Admin_Inventory()
        {
            InitializeComponent();
        }

        private void Admin_Inventory_Load(object sender, EventArgs e)
        {
            Database.DownloadItemList();
            Database.DeserializeItems();

            inventoryList.DataSource = Database.Items;
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string itemCountInput = itemCount.Text;
            if (int.TryParse(itemCountInput, out int itemCountInt))
            {
                Item item = new Item(itemName.Text, itemCountInt);
                Database.Items.Add(item);
                Database.SerializeItems();
                Database.UploadItemList();
                MessageBox.Show("Data successfully added to database.");
                itemName.Clear();
                Database.DownloadItemList();
                Database.DeserializeItems();

                inventoryList.DataSource = Database.Items;
            }
            else
            {
                // The input string is not a valid integer. Display an error message.
                MessageBox.Show("Parsing failed. The input string is not a valid integer. Failed to upload to database.");
            }
        }
    }

}
