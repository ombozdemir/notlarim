using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlarim
{
    public partial class frmSorgu : Form
    {
        public frmSorgu()
        {
            InitializeComponent();
        }
        public static string kontrol="0";
        private string infPath = Application.StartupPath;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
             /*   DateTime currentDateTime = DateTime.Now;
                string  aa= currentDateTime.ToShortDateString();
                if (textBox1.Text == aa.ToString())
                {
                    kontrol = "1";
                    this.Close();
                }*/

                
            try
            {

                string[] lines1 = System.IO.File.ReadAllLines(infPath + @"\user.txt");

                string encr = sss.Decrypt(lines1[0].ToString(), "Omer7980Omer7980");
                if (encr == textBox1.Text)
                {
                    kontrol = "1";
                    this.Close();
                }
              
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
            }

        }

        private void frmSorgu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmSorgu_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void frmSorgu_Load(object sender, EventArgs e)
        {

        }
    }
}
