namespace ClientServerCommunication.View
{
    partial class PasswordRememberForm
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_gonder_mail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(15, 80);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(185, 20);
            this.txt_email.TabIndex = 0;
            // 
            // btn_gonder_mail
            // 
            this.btn_gonder_mail.Location = new System.Drawing.Point(262, 77);
            this.btn_gonder_mail.Name = "btn_gonder_mail";
            this.btn_gonder_mail.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder_mail.TabIndex = 1;
            this.btn_gonder_mail.Text = "Gönder";
            this.btn_gonder_mail.UseVisualStyleBackColor = true;
            this.btn_gonder_mail.Click += new System.EventHandler(this.btn_gonder_mail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen şifresini hatırlamak e-mail adresinizi giriniz...";
            // 
            // PasswordRememberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gonder_mail);
            this.Controls.Add(this.txt_email);
            this.Name = "PasswordRememberForm";
            this.Text = "Password Remember Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_gonder_mail;
        private System.Windows.Forms.Label label1;
    }
}