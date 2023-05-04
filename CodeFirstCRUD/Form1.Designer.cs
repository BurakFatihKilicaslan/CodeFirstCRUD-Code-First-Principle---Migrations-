namespace CodeFirstCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            btnEkle = new Button();
            grpKisiEkleme = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            mtbTelefon = new MaskedTextBox();
            txtSoyad = new TextBox();
            label1 = new Label();
            txtAd = new TextBox();
            grpAra = new GroupBox();
            txtAra = new TextBox();
            btnAra = new Button();
            btnGuncelle = new Button();
            dgvGoruntule = new DataGridView();
            grpKisiEkleme.SuspendLayout();
            grpAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGoruntule).BeginInit();
            SuspendLayout();
            // 
            // sqlDataAdapter1
            // 
            sqlDataAdapter1.DeleteCommand = null;
            sqlDataAdapter1.InsertCommand = null;
            sqlDataAdapter1.SelectCommand = null;
            sqlDataAdapter1.UpdateCommand = null;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(51, 126);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(166, 32);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // grpKisiEkleme
            // 
            grpKisiEkleme.Controls.Add(label2);
            grpKisiEkleme.Controls.Add(label3);
            grpKisiEkleme.Controls.Add(mtbTelefon);
            grpKisiEkleme.Controls.Add(txtSoyad);
            grpKisiEkleme.Controls.Add(label1);
            grpKisiEkleme.Controls.Add(txtAd);
            grpKisiEkleme.Controls.Add(btnEkle);
            grpKisiEkleme.Location = new Point(12, 12);
            grpKisiEkleme.Name = "grpKisiEkleme";
            grpKisiEkleme.Size = new Size(242, 178);
            grpKisiEkleme.TabIndex = 1;
            grpKisiEkleme.TabStop = false;
            grpKisiEkleme.Text = "Kisi Ekleme Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 100);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Soyad";
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(51, 97);
            mtbTelefon.Mask = "(999) 000-00-00";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(166, 23);
            mtbTelefon.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(51, 68);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(166, 23);
            txtSoyad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(51, 39);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(166, 23);
            txtAd.TabIndex = 7;
            // 
            // grpAra
            // 
            grpAra.Controls.Add(txtAra);
            grpAra.Controls.Add(btnAra);
            grpAra.Location = new Point(260, 12);
            grpAra.Name = "grpAra";
            grpAra.Size = new Size(199, 111);
            grpAra.TabIndex = 2;
            grpAra.TabStop = false;
            grpAra.Text = "Ad veya Soyad'a Göre Arama Yap";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(23, 30);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(166, 23);
            txtAra.TabIndex = 5;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(23, 68);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(166, 33);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(283, 138);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(166, 32);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dgvGoruntule
            // 
            dgvGoruntule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoruntule.Location = new Point(12, 196);
            dgvGoruntule.Name = "dgvGoruntule";
            dgvGoruntule.RowTemplate.Height = 25;
            dgvGoruntule.Size = new Size(447, 242);
            dgvGoruntule.TabIndex = 6;
            dgvGoruntule.CellClick += dgvGoruntule_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 447);
            Controls.Add(dgvGoruntule);
            Controls.Add(btnGuncelle);
            Controls.Add(grpAra);
            Controls.Add(grpKisiEkleme);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpKisiEkleme.ResumeLayout(false);
            grpKisiEkleme.PerformLayout();
            grpAra.ResumeLayout(false);
            grpAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGoruntule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Button btnEkle;
        private GroupBox grpKisiEkleme;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtbTelefon;
        private TextBox txtSoyad;
        private Label label1;
        private TextBox txtAd;
        private GroupBox grpAra;
        private TextBox txtAra;
        private Button btnAra;
        private Button btnGuncelle;
        private DataGridView dgvGoruntule;
    }
}