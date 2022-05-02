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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.login_button.Location = new System.Drawing.Point(12, 40);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(199, 68);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "GİRİŞ";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // customerID_textBox
            // 
            this.customerID_textBox.Location = new System.Drawing.Point(47, 12);
            this.customerID_textBox.Name = "customerID_textBox";
            this.customerID_textBox.Size = new System.Drawing.Size(164, 22);
            this.customerID_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // money_textBox
            // 
            this.money_textBox.Location = new System.Drawing.Point(418, 15);
            this.money_textBox.Name = "money_textBox";
            this.money_textBox.Size = new System.Drawing.Size(100, 22);
            this.money_textBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Para Yatır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Para Çek";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createAcc_listBox
            // 
            this.createAcc_listBox.FormattingEnabled = true;
            this.createAcc_listBox.ItemHeight = 16;
            this.createAcc_listBox.Location = new System.Drawing.Point(16, 172);
            this.createAcc_listBox.Name = "createAcc_listBox";
            this.createAcc_listBox.Size = new System.Drawing.Size(120, 68);
            this.createAcc_listBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hesap Aç";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(537, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Para Gönder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Acc_listbox
            // 
            this.Acc_listbox.FormattingEnabled = true;
            this.Acc_listbox.ItemHeight = 16;
            this.Acc_listbox.Location = new System.Drawing.Point(537, 15);
            this.Acc_listbox.Name = "Acc_listbox";
            this.Acc_listbox.Size = new System.Drawing.Size(102, 52);
            this.Acc_listbox.TabIndex = 9;
            // 
            // loginStatus_label
            // 
            this.loginStatus_label.AutoSize = true;
            this.loginStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginStatus_label.ForeColor = System.Drawing.Color.Red;
            this.loginStatus_label.Location = new System.Drawing.Point(13, 111);
            this.loginStatus_label.Name = "loginStatus_label";
            this.loginStatus_label.Size = new System.Drawing.Size(258, 17);
            this.loginStatus_label.TabIndex = 10;
            this.loginStatus_label.Text = "Giriş yapılmadı lütfen giriş yapınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Miktar:";
            // 
            // deleteAcc_listBox
            // 
            this.deleteAcc_listBox.FormattingEnabled = true;
            this.deleteAcc_listBox.ItemHeight = 16;
            this.deleteAcc_listBox.Location = new System.Drawing.Point(16, 275);
            this.deleteAcc_listBox.Name = "deleteAcc_listBox";
            this.deleteAcc_listBox.Size = new System.Drawing.Size(120, 84);
            this.deleteAcc_listBox.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Hesap Sil";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hesap Numarası";
            // 
            // accNumber_textBox
            // 
            this.accNumber_textBox.Location = new System.Drawing.Point(659, 35);
            this.accNumber_textBox.Name = "accNumber_textBox";
            this.accNumber_textBox.Size = new System.Drawing.Size(110, 22);
            this.accNumber_textBox.TabIndex = 15;
            // 
            // logout_button
            // 
            this.logout_button.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.logout_button.Location = new System.Drawing.Point(673, 388);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(96, 36);
            this.logout_button.TabIndex = 16;
            this.logout_button.Text = "ÇIKIŞ";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(418, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Kredi Çek";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Faiz Oranı: %";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 514);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "MÜŞTERİ PANELİ";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label label4;
    }
}