using CodeFirstCRUD.Context;
using CodeFirstCRUD.Models;
using CodeFirstCRUD.Repositories;
using System.Windows.Forms;

namespace CodeFirstCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kisiRepository = new KisiRepository();
            kisi = new Kisi();
        }
        KisiRepository kisiRepository;
        Kisi kisi;
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvGoruntule.DataSource = kisiRepository.GetAll();
            ButonKontrolYap(true);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kisi = new Kisi();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Telefon = mtbTelefon.Text;
            bool isAdded = kisiRepository.Add(kisi);
            if (isAdded)
            {
                MessageBox.Show("Kayıt Ekleme İşleminiz Gerçekleştirilmiştir");
                KontrolleriTemizle();
                dgvGoruntule.DataSource = kisiRepository.GetAll();
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme işleminiz Bir Hata Sebebiyle Gerçekleştirilememiştir");
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            List<Kisi> kisiler = kisiRepository.GetByName(txtAra.Text);
            if (kisiler.Count > 0)
            {
                dgvGoruntule.DataSource = kisiler;
            }
            else
            {
                MessageBox.Show("Arama Kriterlerinize Uygun Kayıt Bulunamamıştır.");
                dgvGoruntule.DataSource = kisiRepository.GetAll();
                txtAra.Clear();
            }
        }
        private void dgvGoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                int id = (int)dgvGoruntule[0, rowIndex].Value;
                kisi = kisiRepository.GetByID(id);
                txtAd.Text = kisi.Ad;
                txtSoyad.Text = kisi.Soyad;
                mtbTelefon.Text = kisi.Telefon;
                ButonKontrolYap(false);
            }
            else
            {
                ButonKontrolYap(true);
                KontrolleriTemizle();
                MessageBox.Show("Herhangi Bir Seçim Yapılmamıştır");
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (kisi is not null)
            {
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.Telefon = mtbTelefon.Text;
                bool isAdded = kisiRepository.Update(kisi);
                if (isAdded)
                {
                    MessageBox.Show("Güncelleme İşlemi Gerçekleştirilmiştir");
                    dgvGoruntule.DataSource = kisiRepository.GetAll();
                    KontrolleriTemizle();
                }
                else
                {
                    MessageBox.Show("Sistemdeki Bakım Sebebiyle Güncelleme İşlemi Yapılamamıştır. Daha Sonra Tekrar Deneyiniz");
                }
            }
        }
        public void ButonKontrolYap(bool durum)
        {
            btnEkle.Enabled = durum;
            btnGuncelle.Enabled = !durum;
        }
        public void KontrolleriTemizle()
        {
            foreach (Control control in grpKisiEkleme.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
            }
        }
    }
}