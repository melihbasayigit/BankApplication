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
            this.createAcc_listBox = new System.Windows.Forms.ListBox();
            this.Acc_listbox = new System.Windows.Forms.ListBox();
            this.loginStatus_label = new System.Windows.Forms.Label();
            this.deleteAcc_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accNumber_textBox = new System.Windows.Forms.TextBox();
            this.interestRatio_label = new System.Windows.Forms.Label();
            this.personInf_label = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.RichTextBox();
            this.updateMyInfo_button = new System.Windows.Forms.Button();
            this.personelInformation_groupBox = new System.Windows.Forms.GroupBox();
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.transfer_groupBox = new System.Windows.Forms.GroupBox();
            this.myAccounts_groupBox = new System.Windows.Forms.GroupBox();
            this.createAcc_button = new System.Windows.Forms.Button();
            this.deleteAcc_button = new System.Windows.Forms.Button();
            this.credit_groupBox = new System.Windows.Forms.GroupBox();
            this.credit_textBox = new System.Windows.Forms.TextBox();
            this.credit_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pay_button = new System.Windows.Forms.Button();
            this.monthly_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.transferMoney_textBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.transferMoney_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelInformation_groupBox.SuspendLayout();
            this.login_groupBox.SuspendLayout();
            this.transfer_groupBox.SuspendLayout();
            this.myAccounts_groupBox.SuspendLayout();
            this.credit_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.login_button.Location = new System.Drawing.Point(14, 41);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(176, 55);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "GİRİŞ";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // customerID_textBox
            // 
            this.customerID_textBox.Location = new System.Drawing.Point(40, 19);
            this.customerID_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerID_textBox.Name = "customerID_textBox";
            this.customerID_textBox.Size = new System.Drawing.Size(150, 20);
            this.customerID_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // createAcc_listBox
            // 
            this.createAcc_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.createAcc_listBox.FormattingEnabled = true;
            this.createAcc_listBox.ItemHeight = 17;
            this.createAcc_listBox.Location = new System.Drawing.Point(5, 18);
            this.createAcc_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.createAcc_listBox.Name = "createAcc_listBox";
            this.createAcc_listBox.Size = new System.Drawing.Size(185, 72);
            this.createAcc_listBox.TabIndex = 6;
            // 
            // Acc_listbox
            // 
            this.Acc_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Acc_listbox.FormattingEnabled = true;
            this.Acc_listbox.ItemHeight = 17;
            this.Acc_listbox.Location = new System.Drawing.Point(9, 118);
            this.Acc_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.Acc_listbox.Name = "Acc_listbox";
            this.Acc_listbox.Size = new System.Drawing.Size(197, 106);
            this.Acc_listbox.TabIndex = 9;
            // 
            // loginStatus_label
            // 
            this.loginStatus_label.AutoSize = true;
            this.loginStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginStatus_label.ForeColor = System.Drawing.Color.Red;
            this.loginStatus_label.Location = new System.Drawing.Point(6, 99);
            this.loginStatus_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginStatus_label.Name = "loginStatus_label";
            this.loginStatus_label.Size = new System.Drawing.Size(198, 13);
            this.loginStatus_label.TabIndex = 10;
            this.loginStatus_label.Text = "Giriş yapılmadı lütfen giriş yapınız.";
            // 
            // deleteAcc_listBox
            // 
            this.deleteAcc_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.deleteAcc_listBox.FormattingEnabled = true;
            this.deleteAcc_listBox.ItemHeight = 17;
            this.deleteAcc_listBox.Location = new System.Drawing.Point(5, 131);
            this.deleteAcc_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAcc_listBox.Name = "deleteAcc_listBox";
            this.deleteAcc_listBox.Size = new System.Drawing.Size(185, 72);
            this.deleteAcc_listBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hesap Numarası: ";
            // 
            // accNumber_textBox
            // 
            this.accNumber_textBox.Location = new System.Drawing.Point(95, 228);
            this.accNumber_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.accNumber_textBox.Name = "accNumber_textBox";
            this.accNumber_textBox.Size = new System.Drawing.Size(111, 20);
            this.accNumber_textBox.TabIndex = 15;
            // 
            // interestRatio_label
            // 
            this.interestRatio_label.AutoSize = true;
            this.interestRatio_label.Location = new System.Drawing.Point(11, 48);
            this.interestRatio_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestRatio_label.Name = "interestRatio_label";
            this.interestRatio_label.Size = new System.Drawing.Size(57, 26);
            this.interestRatio_label.TabIndex = 18;
            this.interestRatio_label.Text = "Faiz Oranı:\r\n%14.75";
            this.interestRatio_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // personInf_label
            // 
            this.personInf_label.AutoSize = true;
            this.personInf_label.Location = new System.Drawing.Point(13, 26);
            this.personInf_label.Name = "personInf_label";
            this.personInf_label.Size = new System.Drawing.Size(49, 91);
            this.personInf_label.TabIndex = 21;
            this.personInf_label.Text = "Adres:\r\n\r\n\r\n\r\nE-mail: \r\n\r\nTelefon: ";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(70, 81);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(120, 20);
            this.email_textBox.TabIndex = 23;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(70, 107);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(120, 20);
            this.phone_textBox.TabIndex = 24;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(70, 26);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(120, 49);
            this.address_textBox.TabIndex = 25;
            this.address_textBox.Text = "";
            // 
            // updateMyInfo_button
            // 
            this.updateMyInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateMyInfo_button.Location = new System.Drawing.Point(16, 133);
            this.updateMyInfo_button.Name = "updateMyInfo_button";
            this.updateMyInfo_button.Size = new System.Drawing.Size(174, 31);
            this.updateMyInfo_button.TabIndex = 26;
            this.updateMyInfo_button.Text = "Bilgilerimi Güncelle";
            this.updateMyInfo_button.UseVisualStyleBackColor = true;
            // 
            // personelInformation_groupBox
            // 
            this.personelInformation_groupBox.Controls.Add(this.updateMyInfo_button);
            this.personelInformation_groupBox.Controls.Add(this.personInf_label);
            this.personelInformation_groupBox.Controls.Add(this.address_textBox);
            this.personelInformation_groupBox.Controls.Add(this.phone_textBox);
            this.personelInformation_groupBox.Controls.Add(this.email_textBox);
            this.personelInformation_groupBox.Location = new System.Drawing.Point(12, 154);
            this.personelInformation_groupBox.Name = "personelInformation_groupBox";
            this.personelInformation_groupBox.Size = new System.Drawing.Size(207, 176);
            this.personelInformation_groupBox.TabIndex = 27;
            this.personelInformation_groupBox.TabStop = false;
            this.personelInformation_groupBox.Text = "Kişisel Bilgilerim";
            // 
            // login_groupBox
            // 
            this.login_groupBox.Controls.Add(this.login_button);
            this.login_groupBox.Controls.Add(this.customerID_textBox);
            this.login_groupBox.Controls.Add(this.label1);
            this.login_groupBox.Controls.Add(this.loginStatus_label);
            this.login_groupBox.Location = new System.Drawing.Point(12, 12);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Size = new System.Drawing.Size(207, 136);
            this.login_groupBox.TabIndex = 28;
            this.login_groupBox.TabStop = false;
            this.login_groupBox.Text = "Giriş Penceresi";
            // 
            // transfer_groupBox
            // 
            this.transfer_groupBox.Controls.Add(this.transferMoney_button);
            this.transfer_groupBox.Controls.Add(this.label4);
            this.transfer_groupBox.Controls.Add(this.transferMoney_textBox);
            this.transfer_groupBox.Controls.Add(this.button6);
            this.transfer_groupBox.Controls.Add(this.button5);
            this.transfer_groupBox.Controls.Add(this.Acc_listbox);
            this.transfer_groupBox.Controls.Add(this.label2);
            this.transfer_groupBox.Controls.Add(this.accNumber_textBox);
            this.transfer_groupBox.Location = new System.Drawing.Point(242, 12);
            this.transfer_groupBox.Name = "transfer_groupBox";
            this.transfer_groupBox.Size = new System.Drawing.Size(224, 402);
            this.transfer_groupBox.TabIndex = 29;
            this.transfer_groupBox.TabStop = false;
            this.transfer_groupBox.Text = "Transfer İşlemlerim";
            // 
            // myAccounts_groupBox
            // 
            this.myAccounts_groupBox.Controls.Add(this.deleteAcc_button);
            this.myAccounts_groupBox.Controls.Add(this.createAcc_button);
            this.myAccounts_groupBox.Controls.Add(this.createAcc_listBox);
            this.myAccounts_groupBox.Controls.Add(this.deleteAcc_listBox);
            this.myAccounts_groupBox.Location = new System.Drawing.Point(12, 336);
            this.myAccounts_groupBox.Name = "myAccounts_groupBox";
            this.myAccounts_groupBox.Size = new System.Drawing.Size(207, 255);
            this.myAccounts_groupBox.TabIndex = 30;
            this.myAccounts_groupBox.TabStop = false;
            this.myAccounts_groupBox.Text = "Hesaplarım";
            // 
            // createAcc_button
            // 
            this.createAcc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createAcc_button.Location = new System.Drawing.Point(5, 95);
            this.createAcc_button.Name = "createAcc_button";
            this.createAcc_button.Size = new System.Drawing.Size(185, 31);
            this.createAcc_button.TabIndex = 27;
            this.createAcc_button.Text = "Hesap Açma Talebi";
            this.createAcc_button.UseVisualStyleBackColor = true;
            // 
            // deleteAcc_button
            // 
            this.deleteAcc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteAcc_button.Location = new System.Drawing.Point(5, 208);
            this.deleteAcc_button.Name = "deleteAcc_button";
            this.deleteAcc_button.Size = new System.Drawing.Size(185, 31);
            this.deleteAcc_button.TabIndex = 28;
            this.deleteAcc_button.Text = "Hesap Silme Talebi";
            this.deleteAcc_button.UseVisualStyleBackColor = true;
            // 
            // credit_groupBox
            // 
            this.credit_groupBox.Controls.Add(this.pay_button);
            this.credit_groupBox.Controls.Add(this.button3);
            this.credit_groupBox.Controls.Add(this.credit_label);
            this.credit_groupBox.Controls.Add(this.credit_textBox);
            this.credit_groupBox.Controls.Add(this.interestRatio_label);
            this.credit_groupBox.Location = new System.Drawing.Point(241, 420);
            this.credit_groupBox.Name = "credit_groupBox";
            this.credit_groupBox.Size = new System.Drawing.Size(225, 134);
            this.credit_groupBox.TabIndex = 30;
            this.credit_groupBox.TabStop = false;
            this.credit_groupBox.Text = "Kredi İşlemlerim";
            // 
            // credit_textBox
            // 
            this.credit_textBox.Location = new System.Drawing.Point(82, 23);
            this.credit_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.credit_textBox.Name = "credit_textBox";
            this.credit_textBox.Size = new System.Drawing.Size(125, 20);
            this.credit_textBox.TabIndex = 31;
            // 
            // credit_label
            // 
            this.credit_label.AutoSize = true;
            this.credit_label.Location = new System.Drawing.Point(29, 26);
            this.credit_label.Name = "credit_label";
            this.credit_label.Size = new System.Drawing.Size(39, 13);
            this.credit_label.TabIndex = 32;
            this.credit_label.Text = "Miktar:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(82, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 31);
            this.button3.TabIndex = 27;
            this.button3.Text = "Kredi Çek";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pay_button
            // 
            this.pay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pay_button.Location = new System.Drawing.Point(14, 85);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(193, 31);
            this.pay_button.TabIndex = 29;
            this.pay_button.Text = "Kredi Borcu Öde";
            this.pay_button.UseVisualStyleBackColor = true;
            // 
            // monthly_button
            // 
            this.monthly_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthly_button.Location = new System.Drawing.Point(241, 560);
            this.monthly_button.Name = "monthly_button";
            this.monthly_button.Size = new System.Drawing.Size(225, 31);
            this.monthly_button.TabIndex = 33;
            this.monthly_button.Text = "Aylık Özet";
            this.monthly_button.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(9, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 31);
            this.button5.TabIndex = 33;
            this.button5.Text = "Para Yatır";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Miktar:";
            // 
            // transferMoney_textBox
            // 
            this.transferMoney_textBox.Location = new System.Drawing.Point(59, 20);
            this.transferMoney_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.transferMoney_textBox.Name = "transferMoney_textBox";
            this.transferMoney_textBox.Size = new System.Drawing.Size(147, 20);
            this.transferMoney_textBox.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(9, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 31);
            this.button6.TabIndex = 36;
            this.button6.Text = "Para Çek";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // transferMoney_button
            // 
            this.transferMoney_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transferMoney_button.Location = new System.Drawing.Point(9, 253);
            this.transferMoney_button.Name = "transferMoney_button";
            this.transferMoney_button.Size = new System.Drawing.Size(197, 31);
            this.transferMoney_button.TabIndex = 37;
            this.transferMoney_button.Text = "Para Gönder";
            this.transferMoney_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 579);
            this.dataGridView1.TabIndex = 34;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthly_button);
            this.Controls.Add(this.credit_groupBox);
            this.Controls.Add(this.myAccounts_groupBox);
            this.Controls.Add(this.transfer_groupBox);
            this.Controls.Add(this.login_groupBox);
            this.Controls.Add(this.personelInformation_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "MÜŞTERİ PANELİ";
            this.personelInformation_groupBox.ResumeLayout(false);
            this.personelInformation_groupBox.PerformLayout();
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            this.transfer_groupBox.ResumeLayout(false);
            this.transfer_groupBox.PerformLayout();
            this.myAccounts_groupBox.ResumeLayout(false);
            this.credit_groupBox.ResumeLayout(false);
            this.credit_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox customerID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox createAcc_listBox;
        private System.Windows.Forms.ListBox Acc_listbox;
        private System.Windows.Forms.Label loginStatus_label;
        private System.Windows.Forms.ListBox deleteAcc_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accNumber_textBox;
        private System.Windows.Forms.Label interestRatio_label;
        private System.Windows.Forms.Label personInf_label;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.RichTextBox address_textBox;
        private System.Windows.Forms.Button updateMyInfo_button;
        private System.Windows.Forms.GroupBox personelInformation_groupBox;
        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.GroupBox transfer_groupBox;
        private System.Windows.Forms.Button transferMoney_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transferMoney_textBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox myAccounts_groupBox;
        private System.Windows.Forms.Button deleteAcc_button;
        private System.Windows.Forms.Button createAcc_button;
        private System.Windows.Forms.GroupBox credit_groupBox;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.TextBox credit_textBox;
        private System.Windows.Forms.Button monthly_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}