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
            dtgwKategoriler = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            txtCategoryId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgwKategoriler).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgwKategoriler);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 222);
            panel1.TabIndex = 0;
            // 
            // dtgwKategoriler
            // 
            dtgwKategoriler.BackgroundColor = SystemColors.ButtonHighlight;
            dtgwKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwKategoriler.Dock = DockStyle.Fill;
            dtgwKategoriler.Location = new Point(0, 0);
            dtgwKategoriler.Name = "dtgwKategoriler";
            dtgwKategoriler.RowHeadersWidth = 51;
            dtgwKategoriler.RowTemplate.Height = 29;
            dtgwKategoriler.Size = new Size(564, 222);
            dtgwKategoriler.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(btnGuncelle);
            panel2.Controls.Add(btnTemizle);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 119);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtCategoryId);
            panel3.Controls.Add(richTextBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 167);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(75, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(129, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(382, 78);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(99, 47);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(80, 40);
            btnTemizle.TabIndex = 0;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(206, 47);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(80, 40);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(303, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(80, 40);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(413, 47);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 40);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(3, 6);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(29, 27);
            txtCategoryId.TabIndex = 3;
            txtCategoryId.Visible = false;
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 508);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormCategories";
            Text = "Kategoriler Yönetimi";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgwKategoriler).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgwKategoriler;
        private Panel panel2;
        private Panel panel3;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnTemizle;
        private TextBox txtCategoryId;
    }
}