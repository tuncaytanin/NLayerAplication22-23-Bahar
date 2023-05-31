namespace NLayerApp.Desktop
{
    partial class FormProduct
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
            panelSearch = new Panel();
            txtNameSearch = new TextBox();
            label3 = new Label();
            btnAra = new Button();
            panelList = new Panel();
            dtgv_ProductList = new DataGridView();
            panelBottom = new Panel();
            lblMessage = new Label();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            panelProduct = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFiyat = new TextBox();
            txtCode = new TextBox();
            txtStok = new TextBox();
            txtName = new TextBox();
            cboxCategory = new ComboBox();
            panelSearch.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_ProductList).BeginInit();
            panelBottom.SuspendLayout();
            panelProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(txtNameSearch);
            panelSearch.Controls.Add(label3);
            panelSearch.Controls.Add(btnAra);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1068, 106);
            panelSearch.TabIndex = 0;
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(395, 32);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(293, 27);
            txtNameSearch.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(342, 36);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Adı";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(739, 25);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 40);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // panelList
            // 
            panelList.Controls.Add(dtgv_ProductList);
            panelList.Dock = DockStyle.Top;
            panelList.Location = new Point(0, 106);
            panelList.Name = "panelList";
            panelList.Size = new Size(1068, 399);
            panelList.TabIndex = 1;
            // 
            // dtgv_ProductList
            // 
            dtgv_ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ProductList.Dock = DockStyle.Fill;
            dtgv_ProductList.Location = new Point(0, 0);
            dtgv_ProductList.Name = "dtgv_ProductList";
            dtgv_ProductList.RowHeadersWidth = 51;
            dtgv_ProductList.RowTemplate.Height = 29;
            dtgv_ProductList.Size = new Size(1068, 399);
            dtgv_ProductList.TabIndex = 0;
            dtgv_ProductList.RowHeaderMouseDoubleClick += dtgv_ProductList_RowHeaderMouseDoubleClick;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(lblMessage);
            panelBottom.Controls.Add(btnTemizle);
            panelBottom.Controls.Add(btnGuncelle);
            panelBottom.Controls.Add(btnSil);
            panelBottom.Controls.Add(btnEkle);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 685);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1068, 115);
            panelBottom.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.FromArgb(192, 0, 0);
            lblMessage.Location = new Point(12, 86);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(87, 20);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "lblMessage";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(799, 21);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(122, 59);
            btnTemizle.TabIndex = 0;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(661, 21);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 59);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(492, 21);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(122, 59);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(325, 21);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 59);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // panelProduct
            // 
            panelProduct.Controls.Add(label6);
            panelProduct.Controls.Add(label5);
            panelProduct.Controls.Add(label4);
            panelProduct.Controls.Add(label2);
            panelProduct.Controls.Add(label1);
            panelProduct.Controls.Add(txtFiyat);
            panelProduct.Controls.Add(txtCode);
            panelProduct.Controls.Add(txtStok);
            panelProduct.Controls.Add(txtName);
            panelProduct.Controls.Add(cboxCategory);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 505);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1068, 180);
            panelProduct.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(800, 124);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 3;
            label6.Text = "Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(451, 125);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 3;
            label5.Text = "Kodu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(81, 125);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Stok";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(465, 56);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Kategori";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(870, 117);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(178, 27);
            txtFiyat.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(521, 118);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(178, 27);
            txtCode.TabIndex = 1;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(151, 118);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(250, 27);
            txtStok.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(521, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(536, 27);
            txtName.TabIndex = 1;
            // 
            // cboxCategory
            // 
            cboxCategory.FormattingEnabled = true;
            cboxCategory.Location = new Point(151, 48);
            cboxCategory.Name = "cboxCategory";
            cboxCategory.Size = new Size(250, 28);
            cboxCategory.TabIndex = 0;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 800);
            Controls.Add(panelProduct);
            Controls.Add(panelBottom);
            Controls.Add(panelList);
            Controls.Add(panelSearch);
            Name = "FormProduct";
            Text = "FormProduct";
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_ProductList).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSearch;
        private Panel panelList;
        private DataGridView dtgv_ProductList;
        private Panel panelBottom;
        private Label lblMessage;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Panel panelProduct;
        private TextBox txtNameSearch;
        private Label label3;
        private Button btnAra;
        private Label label1;
        private TextBox txtName;
        private ComboBox cboxCategory;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtStok;
        private Label label6;
        private TextBox txtFiyat;
    }
}