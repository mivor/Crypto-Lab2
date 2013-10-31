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
    }
}
