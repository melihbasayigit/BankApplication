namespace BankaUygulaması
{
    partial class Form2
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
            this.login_button = new System.Windows.Forms.Button();
            this.customerID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.money_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createAcc_listBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Acc_listbox = new System.Windows.Forms.ListBox();
            this.loginStatus_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteAcc_listBox = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accNumber_textBox = new System.Windows.Forms.TextBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.interestRatio_label = new System.Windows.Forms.Label();
            this.monthly_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.personInf_label = new System.Windows.Forms.Label();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.RichTextBox();
            this.updateMyInfo_button = new System.Windows.Forms.Button();
            this.personelInformation_groupBox = new System.Windows.Forms.GroupBox();
            this.personelInformation_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.login_button.Location = new System.Drawing.Point(9, 32);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(149, 55);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "GİRİŞ";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // customerID_textBox
            // 
            this.customerID_textBox.Location = new System.Drawing.Point(35, 10);
            this.customerID_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerID_textBox.Name = "customerID_textBox";
            this.customerID_textBox.Size = new System.Drawing.Size(124, 20);
            this.customerID_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // money_textBox
            // 
            this.money_textBox.Location = new System.Drawing.Point(314, 12);
            this.money_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.money_textBox.Name = "money_textBox";
            this.money_textBox.Size = new System.Drawing.Size(76, 20);
            this.money_textBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Para Yatır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 5;
            this.button2.Text = "Para Çek";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createAcc_listBox
            // 
            this.createAcc_listBox.FormattingEnabled = true;
            this.createAcc_listBox.Location = new System.Drawing.Point(12, 140);
            this.createAcc_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.createAcc_listBox.Name = "createAcc_listBox";
            this.createAcc_listBox.Size = new System.Drawing.Size(91, 56);
            this.createAcc_listBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 200);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 19);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hesap Aç";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 58);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 19);
            this.button4.TabIndex = 8;
            this.button4.Text = "Para Gönder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Acc_listbox
            // 
            this.Acc_listbox.FormattingEnabled = true;
            this.Acc_listbox.Location = new System.Drawing.Point(403, 12);
            this.Acc_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.Acc_listbox.Name = "Acc_listbox";
            this.Acc_listbox.Size = new System.Drawing.Size(78, 43);
            this.Acc_listbox.TabIndex = 9;
            // 
            // loginStatus_label
            // 
            this.loginStatus_label.AutoSize = true;
            this.loginStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginStatus_label.ForeColor = System.Drawing.Color.Red;
            this.loginStatus_label.Location = new System.Drawing.Point(10, 90);
            this.loginStatus_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginStatus_label.Name = "loginStatus_label";
            this.loginStatus_label.Size = new System.Drawing.Size(198, 13);
            this.loginStatus_label.TabIndex = 10;
            this.loginStatus_label.Text = "Giriş yapılmadı lütfen giriş yapınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Miktar:";
            // 
            // deleteAcc_listBox
            // 
            this.deleteAcc_listBox.FormattingEnabled = true;
            this.deleteAcc_listBox.Location = new System.Drawing.Point(12, 223);
            this.deleteAcc_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAcc_listBox.Name = "deleteAcc_listBox";
            this.deleteAcc_listBox.Size = new System.Drawing.Size(91, 69);
            this.deleteAcc_listBox.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 297);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 19);
            this.button5.TabIndex = 13;
            this.button5.Text = "Hesap Sil";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hesap Numarası";
            // 
            // accNumber_textBox
            // 
            this.accNumber_textBox.Location = new System.Drawing.Point(494, 28);
            this.accNumber_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.accNumber_textBox.Name = "accNumber_textBox";
            this.accNumber_textBox.Size = new System.Drawing.Size(84, 20);
            this.accNumber_textBox.TabIndex = 15;
            // 
            // logout_button
            // 
            this.logout_button.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.logout_button.Location = new System.Drawing.Point(505, 315);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(72, 29);
            this.logout_button.TabIndex = 16;
            this.logout_button.Text = "ÇIKIŞ";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(314, 82);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 19);
            this.button6.TabIndex = 17;
            this.button6.Text = "Kredi Çek";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // interestRatio_label
            // 
            this.interestRatio_label.AutoSize = true;
            this.interestRatio_label.Location = new System.Drawing.Point(248, 75);
            this.interestRatio_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestRatio_label.Name = "interestRatio_label";
            this.interestRatio_label.Size = new System.Drawing.Size(57, 26);
            this.interestRatio_label.TabIndex = 18;
            this.interestRatio_label.Text = "Faiz Oranı:\r\n%14.75";
            this.interestRatio_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // monthly_button
            // 
            this.monthly_button.Location = new System.Drawing.Point(505, 277);
            this.monthly_button.Margin = new System.Windows.Forms.Padding(2);
            this.monthly_button.Name = "monthly_button";
            this.monthly_button.Size = new System.Drawing.Size(72, 34);
            this.monthly_button.TabIndex = 19;
            this.monthly_button.Text = "Aylık Özet";
            this.monthly_button.UseVisualStyleBackColor = true;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(70, 19);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(120, 20);
            this.name_textBox.TabIndex = 20;
            // 
            // personInf_label
            // 
            this.personInf_label.AutoSize = true;
            this.personInf_label.Location = new System.Drawing.Point(13, 26);
            this.personInf_label.Name = "personInf_label";
            this.personInf_label.Size = new System.Drawing.Size(49, 143);
            this.personInf_label.TabIndex = 21;
            this.personInf_label.Text = "Ad: \r\n\r\nSoyad:\r\n \r\nAdres:\r\n\r\n\r\n\r\nE-mail: \r\n\r\nTelefon: ";
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(70, 46);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(120, 20);
            this.surname_textBox.TabIndex = 22;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(70, 130);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(120, 20);
            this.email_textBox.TabIndex = 23;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(70, 156);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(120, 20);
            this.phone_textBox.TabIndex = 24;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(70, 75);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(120, 49);
            this.address_textBox.TabIndex = 25;
            this.address_textBox.Text = "";
            // 
            // updateMyInfo_button
            // 
            this.updateMyInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateMyInfo_button.Location = new System.Drawing.Point(16, 182);
            this.updateMyInfo_button.Name = "updateMyInfo_button";
            this.updateMyInfo_button.Size = new System.Drawing.Size(174, 31);
            this.updateMyInfo_button.TabIndex = 26;
            this.updateMyInfo_button.Text = "Bilgilerimi Güncelle";
            this.updateMyInfo_button.UseVisualStyleBackColor = true;
            // 
            // personelInformation_groupBox
            // 
            this.personelInformation_groupBox.Controls.Add(this.name_textBox);
            this.personelInformation_groupBox.Controls.Add(this.updateMyInfo_button);
            this.personelInformation_groupBox.Controls.Add(this.personInf_label);
            this.personelInformation_groupBox.Controls.Add(this.address_textBox);
            this.personelInformation_groupBox.Controls.Add(this.surname_textBox);
            this.personelInformation_groupBox.Controls.Add(this.phone_textBox);
            this.personelInformation_groupBox.Controls.Add(this.email_textBox);
            this.personelInformation_groupBox.Location = new System.Drawing.Point(182, 140);
            this.personelInformation_groupBox.Name = "personelInformation_groupBox";
            this.personelInformation_groupBox.Size = new System.Drawing.Size(207, 244);
            this.personelInformation_groupBox.TabIndex = 27;
            this.personelInformation_groupBox.TabStop = false;
            this.personelInformation_groupBox.Text = "Kişisel Bilgilerim";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 418);
            this.ControlBox = false;
            this.Controls.Add(this.personelInformation_groupBox);
            this.Controls.Add(this.monthly_button);
            this.Controls.Add(this.interestRatio_label);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.accNumber_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteAcc_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginStatus_label);
            this.Controls.Add(this.Acc_listbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createAcc_listBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.money_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerID_textBox);
            this.Controls.Add(this.login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "MÜŞTERİ PANELİ";
            this.personelInformation_groupBox.ResumeLayout(false);
            this.personelInformation_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox customerID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox money_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox createAcc_listBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox Acc_listbox;
        private System.Windows.Forms.Label loginStatus_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox deleteAcc_listBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accNumber_textBox;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label interestRatio_label;
        private System.Windows.Forms.Button monthly_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label personInf_label;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.RichTextBox address_textBox;
        private System.Windows.Forms.Button updateMyInfo_button;
        private System.Windows.Forms.GroupBox personelInformation_groupBox;
    }
}