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
            this.button1 = new System.Windows.Forms.Button();
            this.customerList_listBox = new System.Windows.Forms.ListBox();
            this.login_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_groupBox
            // 
            this.login_groupBox.Controls.Add(this.id_textBox);
            this.login_groupBox.Controls.Add(this.idStatus_label);
            this.login_groupBox.Controls.Add(this.loginStatus_label);
            this.login_groupBox.Controls.Add(this.id_label);
            this.login_groupBox.Controls.Add(this.button1);
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
            this.idStatus_label.Size = new System.Drawing.Size(41, 13);
            this.idStatus_label.TabIndex = 1;
            this.idStatus_label.Text = "label1";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(116, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "GİRİŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerList_listBox
            // 
            this.customerList_listBox.FormattingEnabled = true;
            this.customerList_listBox.Location = new System.Drawing.Point(285, 24);
            this.customerList_listBox.MultiColumn = true;
            this.customerList_listBox.Name = "customerList_listBox";
            this.customerList_listBox.Size = new System.Drawing.Size(487, 134);
            this.customerList_listBox.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 647);
            this.Controls.Add(this.customerList_listBox);
            this.Controls.Add(this.login_groupBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginStatus_label;
        private System.Windows.Forms.Label idStatus_label;
        private System.Windows.Forms.ListBox customerList_listBox;
        private System.Windows.Forms.TextBox id_textBox;
    }
}