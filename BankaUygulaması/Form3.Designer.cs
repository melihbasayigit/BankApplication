namespace BankaUygulaması
{
    partial class Form3
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
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.idStatus_label = new System.Windows.Forms.Label();
            this.loginStatus_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.customerList_listBox = new System.Windows.Forms.ListBox();
            this.personelInformation_groupBox = new System.Windows.Forms.GroupBox();
            this.customerID_textBox = new System.Windows.Forms.TextBox();
            this.deleteInfo_label = new System.Windows.Forms.Label();
            this.deleteCustomer_checkBox = new System.Windows.Forms.CheckBox();
            this.selectedCustomerID_label = new System.Windows.Forms.Label();
            this.deleteCustomer_button = new System.Windows.Forms.Button();
            this.updateInfo_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.insertNewCustomer_button = new System.Windows.Forms.Button();
            this.personInf_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.RichTextBox();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.customerProc_groupBox = new System.Windows.Forms.GroupBox();
            this.customerTransactions_button = new System.Windows.Forms.Button();
            this.customerRequests_button = new System.Windows.Forms.Button();
            this.customerFinancial_button = new System.Windows.Forms.Button();
            this.customerTransaction_dataGridView = new System.Windows.Forms.DataGridView();
            this.approve_button = new System.Windows.Forms.Button();
            this.reject_button = new System.Windows.Forms.Button();
            this.login_groupBox.SuspendLayout();
            this.personelInformation_groupBox.SuspendLayout();
            this.customerProc_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransaction_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // login_groupBox
            // 
            this.login_groupBox.Controls.Add(this.id_textBox);
            this.login_groupBox.Controls.Add(this.idStatus_label);
            this.login_groupBox.Controls.Add(this.loginStatus_label);
            this.login_groupBox.Controls.Add(this.id_label);
            this.login_groupBox.Controls.Add(this.login_button);
            this.login_groupBox.Location = new System.Drawing.Point(30, 24);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Size = new System.Drawing.Size(215, 131);
            this.login_groupBox.TabIndex = 0;
            this.login_groupBox.TabStop = false;
            this.login_groupBox.Text = "Giriş Penceresi";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(115, 26);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(94, 20);
            this.id_textBox.TabIndex = 2;
            this.id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_textBox_KeyPress);
            // 
            // idStatus_label
            // 
            this.idStatus_label.AutoSize = true;
            this.idStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idStatus_label.Location = new System.Drawing.Point(24, 64);
            this.idStatus_label.Name = "idStatus_label";
            this.idStatus_label.Size = new System.Drawing.Size(60, 13);
            this.idStatus_label.TabIndex = 1;
            this.idStatus_label.Text = "ID Status";
            this.idStatus_label.Visible = false;
            // 
            // loginStatus_label
            // 
            this.loginStatus_label.AutoSize = true;
            this.loginStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.loginStatus_label.ForeColor = System.Drawing.Color.Red;
            this.loginStatus_label.Location = new System.Drawing.Point(6, 97);
            this.loginStatus_label.Name = "loginStatus_label";
            this.loginStatus_label.Size = new System.Drawing.Size(205, 13);
            this.loginStatus_label.TabIndex = 1;
            this.loginStatus_label.Text = "Lütfen müş. temsilcisi girişi yapınız.";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(6, 29);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(104, 13);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "Müş. Temsilcisi ID\'si:";
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.login_button.Location = new System.Drawing.Point(115, 52);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(94, 33);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "GİRİŞ";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerList_listBox
            // 
            this.customerList_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.customerList_listBox.FormattingEnabled = true;
            this.customerList_listBox.ItemHeight = 18;
            this.customerList_listBox.Location = new System.Drawing.Point(30, 170);
            this.customerList_listBox.Name = "customerList_listBox";
            this.customerList_listBox.Size = new System.Drawing.Size(215, 454);
            this.customerList_listBox.TabIndex = 1;
            this.customerList_listBox.SelectedValueChanged += new System.EventHandler(this.customerList_listBox_SelectedValueChanged);
            // 
            // personelInformation_groupBox
            // 
            this.personelInformation_groupBox.Controls.Add(this.customerID_textBox);
            this.personelInformation_groupBox.Controls.Add(this.deleteInfo_label);
            this.personelInformation_groupBox.Controls.Add(this.deleteCustomer_checkBox);
            this.personelInformation_groupBox.Controls.Add(this.selectedCustomerID_label);
            this.personelInformation_groupBox.Controls.Add(this.deleteCustomer_button);
            this.personelInformation_groupBox.Controls.Add(this.updateInfo_button);
            this.personelInformation_groupBox.Controls.Add(this.name_textBox);
            this.personelInformation_groupBox.Controls.Add(this.insertNewCustomer_button);
            this.personelInformation_groupBox.Controls.Add(this.personInf_label);
            this.personelInformation_groupBox.Controls.Add(this.address_textBox);
            this.personelInformation_groupBox.Controls.Add(this.surname_textBox);
            this.personelInformation_groupBox.Controls.Add(this.phone_textBox);
            this.personelInformation_groupBox.Controls.Add(this.email_textBox);
            this.personelInformation_groupBox.Location = new System.Drawing.Point(303, 24);
            this.personelInformation_groupBox.Name = "personelInformation_groupBox";
            this.personelInformation_groupBox.Size = new System.Drawing.Size(207, 434);
            this.personelInformation_groupBox.TabIndex = 28;
            this.personelInformation_groupBox.TabStop = false;
            this.personelInformation_groupBox.Text = "Kişisel Bilgiler";
            // 
            // customerID_textBox
            // 
            this.customerID_textBox.Location = new System.Drawing.Point(70, 21);
            this.customerID_textBox.Name = "customerID_textBox";
            this.customerID_textBox.Size = new System.Drawing.Size(120, 20);
            this.customerID_textBox.TabIndex = 32;
            // 
            // deleteInfo_label
            // 
            this.deleteInfo_label.AutoSize = true;
            this.deleteInfo_label.Location = new System.Drawing.Point(7, 376);
            this.deleteInfo_label.Name = "deleteInfo_label";
            this.deleteInfo_label.Size = new System.Drawing.Size(194, 52);
            this.deleteInfo_label.TabIndex = 31;
            this.deleteInfo_label.Text = "ÖNEMLİ: Müşteri silmek için tüm hesap-\r\nlarındaki bakiye \"0\" (SIFIR) olması \r\nger" +
    "ekmektedir. Bu durum gerçekleş-\r\nmediği takdirde hesap silinemektedir.";
            // 
            // deleteCustomer_checkBox
            // 
            this.deleteCustomer_checkBox.AutoSize = true;
            this.deleteCustomer_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteCustomer_checkBox.ForeColor = System.Drawing.Color.Red;
            this.deleteCustomer_checkBox.Location = new System.Drawing.Point(16, 324);
            this.deleteCustomer_checkBox.Name = "deleteCustomer_checkBox";
            this.deleteCustomer_checkBox.Size = new System.Drawing.Size(173, 30);
            this.deleteCustomer_checkBox.TabIndex = 29;
            this.deleteCustomer_checkBox.Text = "Seçtiğim Müşteriyi Silmek \r\nİSTİYORUM.";
            this.deleteCustomer_checkBox.UseVisualStyleBackColor = true;
            // 
            // selectedCustomerID_label
            // 
            this.selectedCustomerID_label.AutoSize = true;
            this.selectedCustomerID_label.Location = new System.Drawing.Point(160, 357);
            this.selectedCustomerID_label.Name = "selectedCustomerID_label";
            this.selectedCustomerID_label.Size = new System.Drawing.Size(29, 17);
            this.selectedCustomerID_label.TabIndex = 29;
            this.selectedCustomerID_label.Text = "3447";
            this.selectedCustomerID_label.UseCompatibleTextRendering = true;
            this.selectedCustomerID_label.Visible = false;
            // 
            // deleteCustomer_button
            // 
            this.deleteCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteCustomer_button.Location = new System.Drawing.Point(16, 287);
            this.deleteCustomer_button.Name = "deleteCustomer_button";
            this.deleteCustomer_button.Size = new System.Drawing.Size(174, 31);
            this.deleteCustomer_button.TabIndex = 28;
            this.deleteCustomer_button.Text = "Müşteri Sil";
            this.deleteCustomer_button.UseVisualStyleBackColor = true;
            // 
            // updateInfo_button
            // 
            this.updateInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateInfo_button.Location = new System.Drawing.Point(16, 250);
            this.updateInfo_button.Name = "updateInfo_button";
            this.updateInfo_button.Size = new System.Drawing.Size(174, 31);
            this.updateInfo_button.TabIndex = 27;
            this.updateInfo_button.Text = "Bilgilerini Güncelle";
            this.updateInfo_button.UseVisualStyleBackColor = true;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(70, 47);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(120, 20);
            this.name_textBox.TabIndex = 20;
            // 
            // insertNewCustomer_button
            // 
            this.insertNewCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.insertNewCustomer_button.Location = new System.Drawing.Point(16, 213);
            this.insertNewCustomer_button.Name = "insertNewCustomer_button";
            this.insertNewCustomer_button.Size = new System.Drawing.Size(174, 31);
            this.insertNewCustomer_button.TabIndex = 26;
            this.insertNewCustomer_button.Text = "Yeni Müşteri Ekle";
            this.insertNewCustomer_button.UseVisualStyleBackColor = true;
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
            this.address_textBox.Location = new System.Drawing.Point(70, 103);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(120, 49);
            this.address_textBox.TabIndex = 25;
            this.address_textBox.Text = "";
            // 
            // surname_textBox
            // 
            this.surname_textBox.Location = new System.Drawing.Point(70, 74);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(120, 20);
            this.surname_textBox.TabIndex = 22;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(70, 184);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(120, 20);
            this.phone_textBox.TabIndex = 24;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(70, 158);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(120, 20);
            this.email_textBox.TabIndex = 23;
            // 
            // customerProc_groupBox
            // 
            this.customerProc_groupBox.Controls.Add(this.customerTransactions_button);
            this.customerProc_groupBox.Controls.Add(this.customerRequests_button);
            this.customerProc_groupBox.Controls.Add(this.customerFinancial_button);
            this.customerProc_groupBox.Location = new System.Drawing.Point(303, 464);
            this.customerProc_groupBox.Name = "customerProc_groupBox";
            this.customerProc_groupBox.Size = new System.Drawing.Size(207, 165);
            this.customerProc_groupBox.TabIndex = 30;
            this.customerProc_groupBox.TabStop = false;
            this.customerProc_groupBox.Text = "Müşteri İşlemlerim";
            // 
            // customerTransactions_button
            // 
            this.customerTransactions_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerTransactions_button.Location = new System.Drawing.Point(16, 116);
            this.customerTransactions_button.Name = "customerTransactions_button";
            this.customerTransactions_button.Size = new System.Drawing.Size(174, 31);
            this.customerTransactions_button.TabIndex = 28;
            this.customerTransactions_button.Text = "Müşteri Son Haraketleri";
            this.customerTransactions_button.UseVisualStyleBackColor = true;
            // 
            // customerRequests_button
            // 
            this.customerRequests_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerRequests_button.Location = new System.Drawing.Point(16, 79);
            this.customerRequests_button.Name = "customerRequests_button";
            this.customerRequests_button.Size = new System.Drawing.Size(174, 31);
            this.customerRequests_button.TabIndex = 27;
            this.customerRequests_button.Text = "Müşteri Talepleri";
            this.customerRequests_button.UseVisualStyleBackColor = true;
            // 
            // customerFinancial_button
            // 
            this.customerFinancial_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerFinancial_button.Location = new System.Drawing.Point(16, 26);
            this.customerFinancial_button.Name = "customerFinancial_button";
            this.customerFinancial_button.Size = new System.Drawing.Size(174, 47);
            this.customerFinancial_button.TabIndex = 26;
            this.customerFinancial_button.Text = "Müşteri Finansal Durumu";
            this.customerFinancial_button.UseVisualStyleBackColor = true;
            // 
            // customerTransaction_dataGridView
            // 
            this.customerTransaction_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTransaction_dataGridView.Location = new System.Drawing.Point(567, 24);
            this.customerTransaction_dataGridView.Name = "customerTransaction_dataGridView";
            this.customerTransaction_dataGridView.Size = new System.Drawing.Size(554, 568);
            this.customerTransaction_dataGridView.TabIndex = 31;
            // 
            // approve_button
            // 
            this.approve_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.approve_button.ForeColor = System.Drawing.Color.Green;
            this.approve_button.Location = new System.Drawing.Point(567, 598);
            this.approve_button.Name = "approve_button";
            this.approve_button.Size = new System.Drawing.Size(327, 31);
            this.approve_button.TabIndex = 29;
            this.approve_button.Text = "ONAYLA";
            this.approve_button.UseVisualStyleBackColor = true;
            // 
            // reject_button
            // 
            this.reject_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reject_button.ForeColor = System.Drawing.Color.Red;
            this.reject_button.Location = new System.Drawing.Point(900, 598);
            this.reject_button.Name = "reject_button";
            this.reject_button.Size = new System.Drawing.Size(221, 31);
            this.reject_button.TabIndex = 32;
            this.reject_button.Text = "REDDET";
            this.reject_button.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1151, 647);
            this.Controls.Add(this.reject_button);
            this.Controls.Add(this.approve_button);
            this.Controls.Add(this.customerTransaction_dataGridView);
            this.Controls.Add(this.customerProc_groupBox);
            this.Controls.Add(this.personelInformation_groupBox);
            this.Controls.Add(this.customerList_listBox);
            this.Controls.Add(this.login_groupBox);
            this.Name = "Form3";
            this.Text = "MÜŞTERİ TEMSİLCİSİ EKRANI";
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            this.personelInformation_groupBox.ResumeLayout(false);
            this.personelInformation_groupBox.PerformLayout();
            this.customerProc_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTransaction_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label loginStatus_label;
        private System.Windows.Forms.Label idStatus_label;
        private System.Windows.Forms.ListBox customerList_listBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.GroupBox personelInformation_groupBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button insertNewCustomer_button;
        private System.Windows.Forms.Label personInf_label;
        private System.Windows.Forms.RichTextBox address_textBox;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Button updateInfo_button;
        private System.Windows.Forms.Button deleteCustomer_button;
        private System.Windows.Forms.Label deleteInfo_label;
        private System.Windows.Forms.CheckBox deleteCustomer_checkBox;
        private System.Windows.Forms.Label selectedCustomerID_label;
        private System.Windows.Forms.GroupBox customerProc_groupBox;
        private System.Windows.Forms.Button customerTransactions_button;
        private System.Windows.Forms.Button customerRequests_button;
        private System.Windows.Forms.Button customerFinancial_button;
        private System.Windows.Forms.DataGridView customerTransaction_dataGridView;
        private System.Windows.Forms.TextBox customerID_textBox;
        private System.Windows.Forms.Button approve_button;
        private System.Windows.Forms.Button reject_button;
    }
}