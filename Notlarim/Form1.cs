using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlarim
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private string infPath = Application.StartupPath;
      
        private void btnSifrele_Click(object sender, EventArgs e)
        {


            string encr = sss.Encrypt(txtEdit.Text, "Omer7980Omer7980");

 
            System.IO.File.WriteAllText(infPath + @"\conf.txt",encr.ToString());

          
        }



        private void btnOku_Click(object sender, EventArgs e)
        {
            frmSorgu frm = new frmSorgu();
            frm.ShowDialog();
            DateTime currentDateTime = DateTime.Now;
            int week = (int)currentDateTime.DayOfWeek;


            string dd = currentDateTime.ToShortDateString();




            try
            {

                txtEdit.Clear();
                string[] lines1 = System.IO.File.ReadAllLines(infPath + @"\conf.txt");

                for (int i = 0; i < lines1.Length; i++)
                {
                    txtEdit.Text += lines1[i].ToString() + "\r\n";
                }


                string encr = sss.Decrypt(txtEdit.Text, "bzdmr");
                txtEdit.Text = encr;
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }

        
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
   
            DateTime currentDateTime = DateTime.Now;
            int week = (int)currentDateTime.DayOfWeek;
            Random random = new Random();
            int randomNumber = random.Next(0, 10000);
            try
            {
                File.Copy(infPath + @"\conf.txt", infPath + @"\conf-" + currentDateTime.ToShortDateString()+"-"+randomNumber.ToString()+ ".txt");
                MessageBox.Show("Yedekleme başarılı");
            }
            catch (Exception)
            {
                
                throw;
            }
          


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           // btnOku_Click(sender, e);
            lblTarih.Text = DateTime.Now.ToString("h:mm:ss tt");
           // if (frmSorgu.kontrol != "1")
           // {
            //    Application.Exit();
          //  }


        }

        private void txtEdit_KeyDown(object sender, KeyEventArgs e)
        {
            btnSifrele_Click(sender, e);
        }

        private void txtUserSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Şifrenizi Not ediniz " + txtUserSifre.Text);

                btnUserSifre_Click(sender, e);
            }
        }

        private void btnUserSifre_Click(object sender, EventArgs e)
        {

            string encr = sss.Encrypt(txtUserSifre.Text, "bzdmr");


            System.IO.File.WriteAllText(infPath + @"\user.txt", encr.ToString());
        }

        private void txtEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
