namespace Manav_Program
{
    partial class Form1
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
            this.txtMeyve = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMeyve
            // 
            this.txtMeyve.Location = new System.Drawing.Point(80, 49);
            this.txtMeyve.Name = "txtMeyve";
            this.txtMeyve.Size = new System.Drawing.Size(153, 20);
            this.txtMeyve.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(80, 84);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(153, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(239, 49);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(164, 212);
            this.lstSepet.TabIndex = 2;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(80, 143);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(153, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Location = new System.Drawing.Point(80, 113);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(153, 23);
            this.btnSecileniSil.TabIndex = 5;
            this.btnSecileniSil.Text = "Seçileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            this.btnSecileniSil.Click += new System.EventHandler(this.btnSecileniSil_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 307);
            this.Controls.Add(this.btnSecileniSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMeyve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMeyve;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSecileniSil;
    }
}

