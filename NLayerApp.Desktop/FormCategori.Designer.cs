namespace NLayerApp.Desktop
{
    partial class FormCategories
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
            panel1 = new Panel();
            checkHepsiniGetir = new CheckBox();
            dtgwKategoriler = new DataGridView();
            panel2 = new Panel();
            lblMessage = new Label();
            btnSil = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            panel3 = new Panel();
            rtxtDescription = new RichTextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtNameSearch = new TextBox();
            btnAra = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwKategoriler).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkHepsiniGetir);
            panel1.Controls.Add(dtgwKategoriler);
            panel1.Controls.Add(txtNameSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 279);
            panel1.TabIndex = 0;
            // 
            // checkHepsiniGetir
            // 
            checkHepsiniGetir.AutoSize = true;
            checkHepsiniGetir.Location = new Point(489, 12);
            checkHepsiniGetir.Name = "checkHepsiniGetir";
            checkHepsiniGetir.Size = new Size(94, 19);
            checkHepsiniGetir.TabIndex = 1;
            checkHepsiniGetir.Text = "Hepsini Getir";
            checkHepsiniGetir.UseVisualStyleBackColor = true;
            // 
            // dtgwKategoriler
            // 
            dtgwKategoriler.BackgroundColor = SystemColors.ButtonHighlight;
            dtgwKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwKategoriler.Dock = DockStyle.Bottom;
            dtgwKategoriler.Location = new Point(0, 46);
            dtgwKategoriler.Margin = new Padding(3, 2, 3, 2);
            dtgwKategoriler.Name = "dtgwKategoriler";
            dtgwKategoriler.RowHeadersWidth = 51;
            dtgwKategoriler.RowTemplate.Height = 29;
            dtgwKategoriler.Size = new Size(778, 233);
            dtgwKategoriler.TabIndex = 0;
            dtgwKategoriler.RowHeaderMouseDoubleClick += dtgwKategoriler_RowHeaderMouseDoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMessage);
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(btnGuncelle);
            panel2.Controls.Add(btnTemizle);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 392);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 89);
            panel2.TabIndex = 1;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.FromArgb(192, 0, 0);
            lblMessage.Location = new Point(12, 65);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(61, 17);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Message";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(473, 30);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(70, 30);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(377, 30);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(70, 30);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(292, 30);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(70, 30);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(199, 30);
            btnTemizle.Margin = new Padding(3, 2, 3, 2);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(70, 30);
            btnTemizle.TabIndex = 0;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(rtxtDescription);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 279);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 113);
            panel3.TabIndex = 2;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(421, 33);
            rtxtDescription.Margin = new Padding(3, 2, 3, 2);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(335, 60);
            rtxtDescription.TabIndex = 2;
            rtxtDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(359, 36);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // txtName
            // 
            txtName.Location = new Point(44, 33);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(152, 15);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 0;
            label3.Text = "Adı";
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(199, 12);
            txtNameSearch.Margin = new Padding(3, 2, 3, 2);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(257, 23);
            txtNameSearch.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(589, 8);
            btnAra.Margin = new Padding(3, 2, 3, 2);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(70, 30);
            btnAra.TabIndex = 0;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 481);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCategories";
            Text = "Kategoriler Yönetimi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwKategoriler).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgwKategoriler;
        private Panel panel2;
        private Panel panel3;
        private RichTextBox rtxtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Label lblMessage;
        private CheckBox checkHepsiniGetir;
        private TextBox txtNameSearch;
        private Label label3;
        private Button btnAra;
    }
}