namespace BankaUygulaması
{
    partial class Form4
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
            this.customer_listBox = new System.Windows.Forms.ListBox();
            this.newCustomer_groupBox = new System.Windows.Forms.GroupBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.newCustomer_button = new System.Windows.Forms.Button();
            this.personInf_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.RichTextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.allTransaction_dataGridView = new System.Windows.Forms.DataGridView();
            this.bankSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.addCurrency_button = new System.Windows.Forms.Button();
            this.deadlock_button = new System.Windows.Forms.Button();
            this.currencyAddValue_textBox = new System.Windows.Forms.TextBox();
            this.currencyAddName_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currencyCode_textBox = new System.Windows.Forms.TextBox();
            this.listAction_button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.currency_listBox = new System.Windows.Forms.ListBox();
            this.currencyUpdValue_textBox = new System.Windows.Forms.TextBox();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.interestRatio_textBox = new System.Windows.Forms.TextBox();
            this.overdueInterest_textBox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.bankWallet_label = new System.Windows.Forms.Label();
            this.bankProfit_label = new System.Windows.Forms.Label();
            this.bankOutcome_label = new System.Windows.Forms.Label();
            this.bankIncome_label = new System.Windows.Forms.Label();
            this.nextMonth_button = new System.Windows.Forms.Button();
            this.newCustomer_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allTransaction_dataGridView)).BeginInit();
            this.bankSettings_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_listBox
            // 
            this.customer_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.customer_listBox.FormattingEnabled = true;
            this.customer_listBox.ItemHeight = 18;
            this.customer_listBox.Location = new System.Drawing.Point(12, 12);
            this.customer_listBox.Name = "customer_listBox";
            this.customer_listBox.Size = new System.Drawing.Size(282, 580);
            this.customer_listBox.TabIndex = 0;
            this.customer_listBox.SelectedIndexChanged += new System.EventHandler(this.customer_listBox_SelectedIndexChanged);
            // 
            // newCustomer_groupBox
            // 
            this.newCustomer_groupBox.Controls.Add(this.surname_textBox);
            this.newCustomer_groupBox.Controls.Add(this.id_textBox);
            this.newCustomer_groupBox.Controls.Add(this.newCustomer_button);
            this.newCustomer_groupBox.Controls.Add(this.personInf_label);
            this.newCustomer_groupBox.Controls.Add(this.address_textBox);
            this.newCustomer_groupBox.Controls.Add(this.name_textBox);
            this.newCustomer_groupBox.Controls.Add(this.phone_textBox);
            this.newCustomer_groupBox.Controls.Add(this.email_textBox);
            this.newCustomer_groupBox.Location = new System.Drawing.Point(348, 12);
            this.newCustomer_groupBox.Name = "newCustomer_groupBox";
            this.newCustomer_groupBox.Size = new System.Drawing.Size(207, 244);
            this.newCustomer_groupBox.TabIndex = 3;
            this.newCustomer_groupBox.TabStop = false;
            this.newCustomer_groupBox.Text = "Yeni Müşteri Ekle";
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(70, 72);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(120, 20);
            this.surname_textBox.TabIndex = 6;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(70, 19);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(120, 20);
            this.id_textBox.TabIndex = 4;
            this.id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_textBox_KeyPress);
            // 
            // newCustomer_button
            // 
            this.newCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newCustomer_button.Location = new System.Drawing.Point(16, 205);
            this.newCustomer_button.Name = "newCustomer_button";
            this.newCustomer_button.Size = new System.Drawing.Size(174, 31);
            this.newCustomer_button.TabIndex = 10;
            this.newCustomer_button.Text = "Yeni Müşteri Ekle";
            this.newCustomer_button.UseVisualStyleBackColor = true;
            this.newCustomer_button.Click += new System.EventHandler(this.newCustomer_button_Click);
            // 
            // personInf_label
            // 
            this.personInf_label.AutoSize = true;
            this.personInf_label.Location = new System.Drawing.Point(13, 26);
            this.personInf_label.Name = "personInf_label";
            this.personInf_label.Size = new System.Drawing.Size(49, 169);
            this.personInf_label.TabIndex = 21;
            this.personInf_label.Text = "ID:\r\n\r\nAd: \r\n\r\nSoyad:\r\n \r\nAdres:\r\n\r\n\r\n\r\nE-mail: \r\n\r\nTelefon: ";
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(70, 98);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(120, 49);
            this.address_textBox.TabIndex = 7;
            this.address_textBox.Text = "";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(70, 46);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(120, 20);
            this.name_textBox.TabIndex = 5;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(70, 179);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(120, 20);
            this.phone_textBox.TabIndex = 9;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(70, 153);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(120, 20);
            this.email_textBox.TabIndex = 8;
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refresh_button.Location = new System.Drawing.Point(12, 598);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(282, 31);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // allTransaction_dataGridView
            // 
            this.allTransaction_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTransaction_dataGridView.Location = new System.Drawing.Point(348, 275);
            this.allTransaction_dataGridView.Name = "allTransaction_dataGridView";
            this.allTransaction_dataGridView.ReadOnly = true;
            this.allTransaction_dataGridView.Size = new System.Drawing.Size(787, 391);
            this.allTransaction_dataGridView.TabIndex = 25;
            // 
            // bankSettings_groupBox
            // 
            this.bankSettings_groupBox.Controls.Add(this.addCurrency_button);
            this.bankSettings_groupBox.Controls.Add(this.deadlock_button);
            this.bankSettings_groupBox.Controls.Add(this.currencyAddValue_textBox);
            this.bankSettings_groupBox.Controls.Add(this.currencyAddName_textBox);
            this.bankSettings_groupBox.Controls.Add(this.label5);
            this.bankSettings_groupBox.Controls.Add(this.currencyCode_textBox);
            this.bankSettings_groupBox.Controls.Add(this.listAction_button);
            this.bankSettings_groupBox.Controls.Add(this.numericUpDown1);
            this.bankSettings_groupBox.Controls.Add(this.currency_listBox);
            this.bankSettings_groupBox.Controls.Add(this.currencyUpdValue_textBox);
            this.bankSettings_groupBox.Controls.Add(this.salary_textBox);
            this.bankSettings_groupBox.Controls.Add(this.label4);
            this.bankSettings_groupBox.Controls.Add(this.interestRatio_textBox);
            this.bankSettings_groupBox.Controls.Add(this.overdueInterest_textBox);
            this.bankSettings_groupBox.Controls.Add(this.update_button);
            this.bankSettings_groupBox.Controls.Add(this.bankWallet_label);
            this.bankSettings_groupBox.Controls.Add(this.bankProfit_label);
            this.bankSettings_groupBox.Controls.Add(this.bankOutcome_label);
            this.bankSettings_groupBox.Controls.Add(this.bankIncome_label);
            this.bankSettings_groupBox.Location = new System.Drawing.Point(576, 12);
            this.bankSettings_groupBox.Name = "bankSettings_groupBox";
            this.bankSettings_groupBox.Size = new System.Drawing.Size(559, 244);
            this.bankSettings_groupBox.TabIndex = 11;
            this.bankSettings_groupBox.TabStop = false;
            this.bankSettings_groupBox.Text = "Banka Ayarları";
            // 
            // addCurrency_button
            // 
            this.addCurrency_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCurrency_button.Location = new System.Drawing.Point(278, 199);
            this.addCurrency_button.Name = "addCurrency_button";
            this.addCurrency_button.Size = new System.Drawing.Size(133, 31);
            this.addCurrency_button.TabIndex = 23;
            this.addCurrency_button.Text = "Para Birimi Ekle";
            this.addCurrency_button.UseVisualStyleBackColor = true;
            this.addCurrency_button.Click += new System.EventHandler(this.addCurrency_button_Click);
            // 
            // deadlock_button
            // 
            this.deadlock_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deadlock_button.Location = new System.Drawing.Point(420, 199);
            this.deadlock_button.Name = "deadlock_button";
            this.deadlock_button.Size = new System.Drawing.Size(133, 31);
            this.deadlock_button.TabIndex = 24;
            this.deadlock_button.Text = "Deadlock Analizi";
            this.deadlock_button.UseVisualStyleBackColor = true;
            // 
            // currencyAddValue_textBox
            // 
            this.currencyAddValue_textBox.Location = new System.Drawing.Point(371, 173);
            this.currencyAddValue_textBox.Name = "currencyAddValue_textBox";
            this.currencyAddValue_textBox.Size = new System.Drawing.Size(120, 20);
            this.currencyAddValue_textBox.TabIndex = 22;
            // 
            // currencyAddName_textBox
            // 
            this.currencyAddName_textBox.Location = new System.Drawing.Point(371, 147);
            this.currencyAddName_textBox.Name = "currencyAddName_textBox";
            this.currencyAddName_textBox.Size = new System.Drawing.Size(120, 20);
            this.currencyAddName_textBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 65);
            this.label5.TabIndex = 36;
            this.label5.Text = "Kur 3 Harfli Kodu:\r\n\r\nKur İsmi:\r\n\r\nKur Değeri:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currencyCode_textBox
            // 
            this.currencyCode_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.currencyCode_textBox.Location = new System.Drawing.Point(371, 121);
            this.currencyCode_textBox.MaxLength = 3;
            this.currencyCode_textBox.Name = "currencyCode_textBox";
            this.currencyCode_textBox.Size = new System.Drawing.Size(120, 20);
            this.currencyCode_textBox.TabIndex = 20;
            this.currencyCode_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currencyCode_textBox_KeyPress);
            // 
            // listAction_button
            // 
            this.listAction_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAction_button.Location = new System.Drawing.Point(123, 195);
            this.listAction_button.Name = "listAction_button";
            this.listAction_button.Size = new System.Drawing.Size(120, 31);
            this.listAction_button.TabIndex = 19;
            this.listAction_button.Text = "Listele";
            this.listAction_button.UseVisualStyleBackColor = true;
            this.listAction_button.Click += new System.EventHandler(this.listAction_button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(123, 168);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currency_listBox
            // 
            this.currency_listBox.FormattingEnabled = true;
            this.currency_listBox.Location = new System.Drawing.Point(18, 131);
            this.currency_listBox.Name = "currency_listBox";
            this.currency_listBox.Size = new System.Drawing.Size(99, 95);
            this.currency_listBox.TabIndex = 16;
            this.currency_listBox.SelectedValueChanged += new System.EventHandler(this.currency_listBox_SelectedValueChanged);
            // 
            // currencyUpdValue_textBox
            // 
            this.currencyUpdValue_textBox.Location = new System.Drawing.Point(123, 105);
            this.currencyUpdValue_textBox.Name = "currencyUpdValue_textBox";
            this.currencyUpdValue_textBox.Size = new System.Drawing.Size(120, 20);
            this.currencyUpdValue_textBox.TabIndex = 15;
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(123, 79);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(120, 20);
            this.salary_textBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 91);
            this.label4.TabIndex = 29;
            this.label4.Text = "Kredi Faiz Oranı:\r\n\r\nGecikme Faiz Oranı:\r\n\r\nÇalışan Ücreti:\r\n\r\nKur Değeri:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // interestRatio_textBox
            // 
            this.interestRatio_textBox.Location = new System.Drawing.Point(123, 26);
            this.interestRatio_textBox.Name = "interestRatio_textBox";
            this.interestRatio_textBox.Size = new System.Drawing.Size(120, 20);
            this.interestRatio_textBox.TabIndex = 12;
            // 
            // overdueInterest_textBox
            // 
            this.overdueInterest_textBox.Location = new System.Drawing.Point(123, 53);
            this.overdueInterest_textBox.Name = "overdueInterest_textBox";
            this.overdueInterest_textBox.Size = new System.Drawing.Size(120, 20);
            this.overdueInterest_textBox.TabIndex = 13;
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_button.Location = new System.Drawing.Point(123, 131);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(120, 31);
            this.update_button.TabIndex = 17;
            this.update_button.Text = "Güncelle";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // bankWallet_label
            // 
            this.bankWallet_label.AutoSize = true;
            this.bankWallet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bankWallet_label.ForeColor = System.Drawing.Color.Blue;
            this.bankWallet_label.Location = new System.Drawing.Point(274, 88);
            this.bankWallet_label.Name = "bankWallet_label";
            this.bankWallet_label.Size = new System.Drawing.Size(202, 20);
            this.bankWallet_label.TabIndex = 3;
            this.bankWallet_label.Text = "Toplam: 150.000.000 TL";
            this.bankWallet_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // bankProfit_label
            // 
            this.bankProfit_label.AutoSize = true;
            this.bankProfit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bankProfit_label.ForeColor = System.Drawing.Color.Chocolate;
            this.bankProfit_label.Location = new System.Drawing.Point(274, 63);
            this.bankProfit_label.Name = "bankProfit_label";
            this.bankProfit_label.Size = new System.Drawing.Size(161, 20);
            this.bankProfit_label.TabIndex = 2;
            this.bankProfit_label.Text = "Kar: 25.000.000 TL";
            this.bankProfit_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // bankOutcome_label
            // 
            this.bankOutcome_label.AutoSize = true;
            this.bankOutcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bankOutcome_label.ForeColor = System.Drawing.Color.Maroon;
            this.bankOutcome_label.Location = new System.Drawing.Point(274, 38);
            this.bankOutcome_label.Name = "bankOutcome_label";
            this.bankOutcome_label.Size = new System.Drawing.Size(184, 20);
            this.bankOutcome_label.TabIndex = 1;
            this.bankOutcome_label.Text = "Gider: -15.000.000 TL";
            // 
            // bankIncome_label
            // 
            this.bankIncome_label.AutoSize = true;
            this.bankIncome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bankIncome_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.bankIncome_label.Location = new System.Drawing.Point(274, 13);
            this.bankIncome_label.Name = "bankIncome_label";
            this.bankIncome_label.Size = new System.Drawing.Size(172, 20);
            this.bankIncome_label.TabIndex = 0;
            this.bankIncome_label.Text = "Gelir: +30.000.00 TL";
            // 
            // nextMonth_button
            // 
            this.nextMonth_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextMonth_button.Location = new System.Drawing.Point(12, 635);
            this.nextMonth_button.Name = "nextMonth_button";
            this.nextMonth_button.Size = new System.Drawing.Size(282, 31);
            this.nextMonth_button.TabIndex = 2;
            this.nextMonth_button.Text = "Sistemi Bir Ay İleri Al";
            this.nextMonth_button.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 683);
            this.Controls.Add(this.nextMonth_button);
            this.Controls.Add(this.bankSettings_groupBox);
            this.Controls.Add(this.allTransaction_dataGridView);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.newCustomer_groupBox);
            this.Controls.Add(this.customer_listBox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.newCustomer_groupBox.ResumeLayout(false);
            this.newCustomer_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allTransaction_dataGridView)).EndInit();
            this.bankSettings_groupBox.ResumeLayout(false);
            this.bankSettings_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox customer_listBox;
        private System.Windows.Forms.GroupBox newCustomer_groupBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Button newCustomer_button;
        private System.Windows.Forms.Label personInf_label;
        private System.Windows.Forms.RichTextBox address_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView allTransaction_dataGridView;
        private System.Windows.Forms.GroupBox bankSettings_groupBox;
        private System.Windows.Forms.Label bankWallet_label;
        private System.Windows.Forms.Label bankProfit_label;
        private System.Windows.Forms.Label bankOutcome_label;
        private System.Windows.Forms.Label bankIncome_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button nextMonth_button;
        private System.Windows.Forms.Button deadlock_button;
        private System.Windows.Forms.TextBox currencyAddValue_textBox;
        private System.Windows.Forms.TextBox currencyAddName_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currencyCode_textBox;
        private System.Windows.Forms.Button listAction_button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox currency_listBox;
        private System.Windows.Forms.TextBox currencyUpdValue_textBox;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interestRatio_textBox;
        private System.Windows.Forms.TextBox overdueInterest_textBox;
        private System.Windows.Forms.Button addCurrency_button;
        private System.Windows.Forms.TextBox surname_textBox;
    }
}