using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OEMInformation
{
    public partial class Main : Form
    {
        OpenFileDialog openFileDialog;
        OEMInformation oemInformation;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            oemInformation = new OEMInformation();
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.bmp|*.bmp";
            openFileDialog.ShowDialog();

            if (string.IsNullOrWhiteSpace(openFileDialog.FileName)) return;
            
            pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            oemInformation.Logo = openFileDialog.FileName;
            oemInformation.Manufacturer = textBoxManufacturer.Text;
            oemInformation.Model = textBoxModel.Text;
            oemInformation.SupportHours = textBoxSupportHours.Text;
            oemInformation.SupportPhone = textBoxSupportPhone.Text;
            oemInformation.SupportURL = textBoxSupportURL.Text;
            oemInformation.SaveChanges();

            MessageBox.Show("Done");
        }
    }
}
