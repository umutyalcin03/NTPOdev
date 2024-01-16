namespace OkulApp
{
    partial class FrmGiris
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
            this.lblgiris = new System.Windows.Forms.Label();
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnOgretmenKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgiris
            // 
            this.lblgiris.AutoSize = true;
            this.lblgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiris.Location = new System.Drawing.Point(77, 49);
            this.lblgiris.Name = "lblgiris";
            this.lblgiris.Size = new System.Drawing.Size(224, 18);
            this.lblgiris.TabIndex = 0;
            this.lblgiris.Text = "Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.Location = new System.Drawing.Point(12, 101);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(177, 70);
            this.btnOgrenciKayit.TabIndex = 1;
            this.btnOgrenciKayit.Text = "Öğrenci Kayıt";
            this.btnOgrenciKayit.UseVisualStyleBackColor = true;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnOgretmenKayit
            // 
            this.btnOgretmenKayit.Location = new System.Drawing.Point(195, 101);
            this.btnOgretmenKayit.Name = "btnOgretmenKayit";
            this.btnOgretmenKayit.Size = new System.Drawing.Size(177, 70);
            this.btnOgretmenKayit.TabIndex = 2;
            this.btnOgretmenKayit.Text = "Öğretmen Kayıt";
            this.btnOgretmenKayit.UseVisualStyleBackColor = true;
            this.btnOgretmenKayit.Click += new System.EventHandler(this.btnOgretmenKayit_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 210);
            this.Controls.Add(this.btnOgretmenKayit);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Controls.Add(this.lblgiris);
            this.Name = "FrmGiris";
            this.Text = "Öğrenci/Öğretmen Kayıt Seçme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgiris;
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnOgretmenKayit;
    }
}