namespace Notlarim
{
    partial class frmMain
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
            this.txtSifreli = new System.Windows.Forms.RichTextBox();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUserSifre = new System.Windows.Forms.Button();
            this.txtUserSifre = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSifreli
            // 
            this.txtSifreli.Location = new System.Drawing.Point(880, 399);
            this.txtSifreli.Name = "txtSifreli";
            this.txtSifreli.Size = new System.Drawing.Size(117, 32);
            this.txtSifreli.TabIndex = 3;
            this.txtSifreli.Text = "";
            this.txtSifreli.Visible = false;
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(880, 193);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(117, 82);
            this.btnOku.TabIndex = 2;
            this.btnOku.Text = "OKU";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Visible = false;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(880, 291);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(117, 82);
            this.btnSifrele.TabIndex = 1;
            this.btnSifrele.Text = "SAKLA";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Visible = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnUserSifre);
            this.panel2.Controls.Add(this.txtUserSifre);
            this.panel2.Controls.Add(this.lblTarih);
            this.panel2.Controls.Add(this.btnYedekle);
            this.panel2.Controls.Add(this.btnOku);
            this.panel2.Controls.Add(this.txtSifreli);
            this.panel2.Controls.Add(this.btnSifrele);
            this.panel2.Controls.Add(this.txtEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 792);
            this.panel2.TabIndex = 0;
            // 
            // btnUserSifre
            // 
            this.btnUserSifre.Location = new System.Drawing.Point(880, 460);
            this.btnUserSifre.Name = "btnUserSifre";
            this.btnUserSifre.Size = new System.Drawing.Size(117, 82);
            this.btnUserSifre.TabIndex = 8;
            this.btnUserSifre.Text = "USER SIFRE";
            this.btnUserSifre.UseVisualStyleBackColor = true;
            this.btnUserSifre.Visible = false;
            this.btnUserSifre.Click += new System.EventHandler(this.btnUserSifre_Click);
            // 
            // txtUserSifre
            // 
            this.txtUserSifre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSifre.Location = new System.Drawing.Point(880, 46);
            this.txtUserSifre.Name = "txtUserSifre";
            this.txtUserSifre.Size = new System.Drawing.Size(117, 20);
            this.txtUserSifre.TabIndex = 7;
            this.txtUserSifre.TextChanged += new System.EventHandler(this.txtUserSifre_TextChanged);
            this.txtUserSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserSifre_KeyDown);
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(892, 9);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(13, 20);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = ".";
            // 
            // btnYedekle
            // 
            this.btnYedekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYedekle.Location = new System.Drawing.Point(880, 90);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(117, 82);
            this.btnYedekle.TabIndex = 4;
            this.btnYedekle.Text = "YEDEKLE";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.SystemColors.Info;
            this.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEdit.Location = new System.Drawing.Point(0, 0);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(1015, 792);
            this.txtEdit.TabIndex = 0;
            this.txtEdit.Text = "";
            this.txtEdit.TextChanged += new System.EventHandler(this.txtEdit_TextChanged);
            this.txtEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdit_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 792);
            this.Controls.Add(this.panel2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notlarım";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtEdit;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.RichTextBox txtSifreli;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtUserSifre;
        private System.Windows.Forms.Button btnUserSifre;
    }
}

