using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Crypto_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Initialize lists with enum values
            listMode.DataSource = Enum.GetValues(typeof(CipherMode));
            listPadding.DataSource = Enum.GetValues(typeof(PaddingMode));
            listAlgorithm.DataSource = Enum.GetValues(typeof(Program.AlgName));
        }

        //returns selected file name
        private string getExstFileName()
        {
            string name = "No file selected!";
            DialogResult result = openDialog.ShowDialog();
            if ( result == DialogResult.OK )
            {
                name = openDialog.FileName;
            }
            return name;
        }

        //returns new file name
        private string getNewFileName()
        {
            string name = "No name given!";
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                name = saveDialog.FileName;
            }
            return name;
        }

        private void btnNrmNew_Click(object sender, EventArgs e)
        {
            txtNrmFile.Text = getNewFileName();
        }

        private void btnNrmExs_Click(object sender, EventArgs e)
        {
            txtNrmFile.Text = getExstFileName();
        }

        private void btnEncNew_Click(object sender, EventArgs e)
        {
            txtEncFile.Text = getNewFileName();
        }

        private void btnEncExs_Click(object sender, EventArgs e)
        {
            txtEncFile.Text = getExstFileName();
        }
    }
}
