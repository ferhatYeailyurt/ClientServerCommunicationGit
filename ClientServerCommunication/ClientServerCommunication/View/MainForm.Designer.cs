﻿namespace ClientServerCommunication.View
{
    partial class MainForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_userList = new System.Windows.Forms.Button();
            this.lstView_User = new System.Windows.Forms.ListView();
            this.btn_userSelect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(697, 15);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // btn_userList
            // 
            this.btn_userList.Location = new System.Drawing.Point(20, 28);
            this.btn_userList.Name = "btn_userList";
            this.btn_userList.Size = new System.Drawing.Size(75, 23);
            this.btn_userList.TabIndex = 2;
            this.btn_userList.Text = "Listele";
            this.btn_userList.UseVisualStyleBackColor = true;
            this.btn_userList.Click += new System.EventHandler(this.btn_userList_Click);
            // 
            // lstView_User
            // 
            this.lstView_User.Location = new System.Drawing.Point(16, 73);
            this.lstView_User.Name = "lstView_User";
            this.lstView_User.Size = new System.Drawing.Size(166, 296);
            this.lstView_User.TabIndex = 5;
            this.lstView_User.UseCompatibleStateImageBehavior = false;
            this.lstView_User.SelectedIndexChanged += new System.EventHandler(this.lstView_User_SelectedIndexChanged);
            // 
            // btn_userSelect
            // 
            this.btn_userSelect.Location = new System.Drawing.Point(107, 28);
            this.btn_userSelect.Name = "btn_userSelect";
            this.btn_userSelect.Size = new System.Drawing.Size(86, 23);
            this.btn_userSelect.TabIndex = 7;
            this.btn_userSelect.Text = "Kullanıcı Seç:";
            this.btn_userSelect.UseVisualStyleBackColor = true;
            this.btn_userSelect.Click += new System.EventHandler(this.btn_userSelect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_userSelect);
            this.Controls.Add(this.lstView_User);
            this.Controls.Add(this.btn_userList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLabel);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_userList;
        public System.Windows.Forms.ListView lstView_User;
        private System.Windows.Forms.Button btn_userSelect;
        private System.Windows.Forms.Button button1;
    }
}