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
            panelList = new Panel();
            panelBottom = new Panel();
            panelProduct = new Panel();
            dtgv_ProductList = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            lblMessage = new Label();
            panelList.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_ProductList).BeginInit();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1307, 106);
            panelSearch.TabIndex = 0;
            // 
            // panelList
            // 
            panelList.Controls.Add(dtgv_ProductList);
            panelList.Dock = DockStyle.Top;
            panelList.Location = new Point(0, 106);
            panelList.Name = "panelList";
            panelList.Size = new Size(1307, 336);
            panelList.TabIndex = 1;
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
            panelBottom.Size = new Size(1307, 115);
            panelBottom.TabIndex = 2;
            // 
            // panelProduct
            // 
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(0, 442);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(1307, 243);
            panelProduct.TabIndex = 3;
            // 
            // dtgv_ProductList
            // 
            dtgv_ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ProductList.Dock = DockStyle.Fill;
            dtgv_ProductList.Location = new Point(0, 0);
            dtgv_ProductList.Name = "dtgv_ProductList";
            dtgv_ProductList.RowHeadersWidth = 51;
            dtgv_ProductList.RowTemplate.Height = 29;
            dtgv_ProductList.Size = new Size(1307, 336);
            dtgv_ProductList.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(325, 21);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(122, 59);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(492, 21);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(122, 59);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(661, 21);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(122, 59);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(799, 21);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(122, 59);
            btnTemizle.TabIndex = 0;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
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
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 800);
            Controls.Add(panelProduct);
            Controls.Add(panelBottom);
            Controls.Add(panelList);
            Controls.Add(panelSearch);
            Name = "FormProduct";
            Text = "FormProduct";
            panelList.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_ProductList).EndInit();
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
    }
}