namespace KutuphaneOtomasyonu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKitapList = new System.Windows.Forms.ListBox();
            this.lstKitapListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpKira = new System.Windows.Forms.GroupBox();
            this.grpKiraList = new System.Windows.Forms.GroupBox();
            this.lstKiraList = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lstKitapListContextMenu.SuspendLayout();
            this.grpKira.SuspendLayout();
            this.grpKiraList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(136, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(65, 69);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(146, 20);
            this.txtAdet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(65, 29);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(146, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKitapList);
            this.groupBox2.Location = new System.Drawing.Point(236, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lstKitapList
            // 
            this.lstKitapList.ContextMenuStrip = this.lstKitapListContextMenu;
            this.lstKitapList.FormattingEnabled = true;
            this.lstKitapList.Location = new System.Drawing.Point(7, 20);
            this.lstKitapList.Name = "lstKitapList";
            this.lstKitapList.Size = new System.Drawing.Size(489, 199);
            this.lstKitapList.TabIndex = 0;
            this.lstKitapList.SelectedIndexChanged += new System.EventHandler(this.lstKitapList_SelectedIndexChanged);
            // 
            // lstKitapListContextMenu
            // 
            this.lstKitapListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.lstKitapListContextMenu.Name = "lstKitapListContextMenu";
            this.lstKitapListContextMenu.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // grpKira
            // 
            this.grpKira.Controls.Add(this.lblKitapAdi);
            this.grpKira.Controls.Add(this.dtDay);
            this.grpKira.Controls.Add(this.label4);
            this.grpKira.Controls.Add(this.btnKirala);
            this.grpKira.Controls.Add(this.txtName);
            this.grpKira.Controls.Add(this.label3);
            this.grpKira.Location = new System.Drawing.Point(13, 256);
            this.grpKira.Name = "grpKira";
            this.grpKira.Size = new System.Drawing.Size(216, 206);
            this.grpKira.TabIndex = 2;
            this.grpKira.TabStop = false;
            this.grpKira.Text = "Kitap Kirala";
            // 
            // grpKiraList
            // 
            this.grpKiraList.Controls.Add(this.lstKiraList);
            this.grpKiraList.Location = new System.Drawing.Point(235, 265);
            this.grpKiraList.Name = "grpKiraList";
            this.grpKiraList.Size = new System.Drawing.Size(503, 197);
            this.grpKiraList.TabIndex = 3;
            this.grpKiraList.TabStop = false;
            // 
            // lstKiraList
            // 
            this.lstKiraList.FormattingEnabled = true;
            this.lstKiraList.Location = new System.Drawing.Point(8, 20);
            this.lstKiraList.Name = "lstKiraList";
            this.lstKiraList.Size = new System.Drawing.Size(489, 160);
            this.lstKiraList.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kişi:";
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(135, 177);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKirala.TabIndex = 5;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gün:";
            // 
            // dtDay
            // 
            this.dtDay.Location = new System.Drawing.Point(36, 84);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(174, 20);
            this.dtDay.TabIndex = 7;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(95, 29);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(0, 18);
            this.lblKitapAdi.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 474);
            this.Controls.Add(this.grpKiraList);
            this.Controls.Add(this.grpKira);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Kütüphane Otomasyonu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.lstKitapListContextMenu.ResumeLayout(false);
            this.grpKira.ResumeLayout(false);
            this.grpKira.PerformLayout();
            this.grpKiraList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKitapList;
        private System.Windows.Forms.GroupBox grpKira;
        private System.Windows.Forms.GroupBox grpKiraList;
        private System.Windows.Forms.ListBox lstKiraList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip lstKitapListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.Label lblKitapAdi;
    }
}