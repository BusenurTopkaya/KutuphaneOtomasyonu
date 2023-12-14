using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginMethod()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                //form2 olarak bir form tanımlaması gerçekleştirdim ve bu formun login olduktan sonra görünmesini sağladım.
                using (var form = new Form2())
                {
                    Hide();
                    form.ShowDialog();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Yanlış.");
            }
        }
  
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginMethod();
            }
        }
    }
}
