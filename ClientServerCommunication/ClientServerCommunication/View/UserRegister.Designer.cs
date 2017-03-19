namespace ClientServerCommunication.View
{
    partial class UserRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.returnForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(155, 28);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 4;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(155, 67);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_soyadi.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(155, 105);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 6;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(155, 139);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 7;
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(46, 221);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(75, 23);
            this.kaydet_btn.TabIndex = 8;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // temizle_btn
            // 
            this.temizle_btn.Location = new System.Drawing.Point(145, 220);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(75, 23);
            this.temizle_btn.TabIndex = 9;
            this.temizle_btn.Text = "Temizle";
            this.temizle_btn.UseVisualStyleBackColor = true;
            // 
            // returnForm
            // 
            this.returnForm.Location = new System.Drawing.Point(250, 221);
            this.returnForm.Name = "returnForm";
            this.returnForm.Size = new System.Drawing.Size(75, 23);
            this.returnForm.TabIndex = 10;
            this.returnForm.Text = "Geri Dön";
            this.returnForm.UseVisualStyleBackColor = true;
            this.returnForm.Click += new System.EventHandler(this.returnForm_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 284);
            this.Controls.Add(this.returnForm);
            this.Controls.Add(this.temizle_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserRegister";
            this.Text = "User Register";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.Button returnForm;
    }
}