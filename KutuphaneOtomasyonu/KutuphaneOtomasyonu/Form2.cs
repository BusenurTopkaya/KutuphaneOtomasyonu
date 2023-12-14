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
    public partial class Form2 : Form
    {
        List<string> bookNameList = new List<string>();
        List<int> bookQuantityList = new List<int>();

        List<string> kiralayanKisiList = new List<string>();
        List<string> kiralananTarihList = new List<string>();
        List<int> kiralananKitapList = new List<int>();

        string bookName;
        string seciliKitap = string.Empty;
        int quantityIndex;
        bool isUpdate = false;
        public Form2()
        {
            InitializeComponent();
        }

        //Selected book seçili kitabı getirmemize yarıyor. 
        private int SelectedBook(out string bookName, ref string lstItem)
        {

            string seciliKitap = lstKitapList.SelectedItem.ToString();

            var splitData = seciliKitap.Split(':');

            bookName = splitData[0];
            lstItem = seciliKitap;

            var quantityIndex = bookNameList.IndexOf(bookName);
            return quantityIndex;

        }

        //GetSelectedBook ise secili kitabı gerekli değişkenlere atamamıza yarar
        private void GetSelectedBook()
        {
            quantityIndex = SelectedBook(out bookName, ref seciliKitap);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string book = txtKitapAdi.Text;
            int quantity;

            bool isNumber = int.TryParse(txtAdet.Text, out quantity);

            if (String.IsNullOrWhiteSpace(book))
            {
                MessageBox.Show("Lütfen Kitap adını giriniz.");
                return;
            }

            if (!isNumber)
            {
                MessageBox.Show("Adet doğru girilmedi lütfen doğru adedi giriniz.");
                txtAdet.Clear();
                return;
            }

            if (quantity < 0)
            {
                MessageBox.Show("0 dan küçük adet giremezsiniz.");
                return;
            }

            string lstData = string.Format("{0}:{1} adet", book, quantity);

            if (isUpdate)
            {
                GetSelectedBook();

                bookQuantityList[quantityIndex] = Convert.ToInt32(txtAdet.Text);

                lstKitapList.Items[lstKitapList.SelectedIndex] = lstData;

                btnEkle.Text = "Ekle";

                txtAdet.Clear();
                txtKitapAdi.Clear();
                txtKitapAdi.Enabled = true;

                isUpdate = false;

                grpKira.Enabled = true;
                grpKiraList.Enabled = true;
            }
            else
            {
                bookNameList.Add(book);
                bookQuantityList.Add(quantity);

                lstKitapList.Items.Add(lstData);

                txtAdet.Clear();
                txtKitapAdi.Clear();
                MessageBox.Show("Giriş Yapılmıştır.");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKitapList.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kitap seçiniz.");
                return;
            }

            GetSelectedBook();

            string question = String.Format("{0} isimli kitabı silmek istediğinizden emin misiniz?", bookName);

            DialogResult result = MessageBox.Show(question, "Silmek İstiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bookNameList.Remove(bookName);

                bookQuantityList.RemoveAt(quantityIndex);

                lstKitapList.Items.Remove(seciliKitap);

                string message = String.Format("{0} isimli kitap silinmiştir.", bookName);

                MessageBox.Show(message);
            }


        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKitapList.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kitap seçiniz.");
                return;
            }


            GetSelectedBook();
            txtKitapAdi.Text = bookName;
            txtKitapAdi.Enabled = false;
            txtAdet.Text = bookQuantityList[quantityIndex].ToString();

            btnEkle.Text = "Güncelle";

            isUpdate = true;

            grpKira.Enabled = false;
            grpKiraList.Enabled = false;

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if(lstKitapList.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Kitap Seçiniz.");
                return;
            }

            GetSelectedBook();

            int quantity = bookQuantityList[quantityIndex];

            if (quantity < 1)
            {
                MessageBox.Show("Kiralanacak kadar adet bulunamadı.");
                return;
            }

            bookQuantityList[quantityIndex] -= 1;

            string name = txtName.Text;
            var date = dtDay.Value.ToString("dd-MM-yyyy");

            double diffDay = Math.Truncate((dtDay.Value - DateTime.Now).TotalDays);

            string kiralanan = string.Format("{0} kitabını {1} kişisi {2} tarihinden {3} tarihine kadar {4} gün kiralamıştır.", bookName, name, DateTime.Now.ToString("dd-MM-yyyy"), date, diffDay);

            lstKiraList.Items.Add(kiralanan);

            kiralayanKisiList.Add(name);
            kiralananTarihList.Add(date);
            kiralananKitapList.Add(quantityIndex);


            txtName.Clear();
            dtDay.Value = DateTime.Now;

            string lstData = string.Format("{0}:{1} adet", bookName, bookQuantityList[quantityIndex]);

            lstKitapList.Items[lstKitapList.SelectedIndex] = lstData;

            lstKitapList.ClearSelected();

            lblKitapAdi.Text = string.Empty;
        }

        private void lstKitapList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitapList.SelectedItem == null)
            {
                return;
            }

            GetSelectedBook();

            lblKitapAdi.Text = bookName;
        }


    }
}
