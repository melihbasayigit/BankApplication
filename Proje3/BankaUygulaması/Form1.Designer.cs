namespace BankaUygulaması
{
    partial class mainMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.customer_but = new System.Windows.Forms.Button();
            this.but_rep = new System.Windows.Forms.Button();
            this.but_bankmanager = new System.Windows.Forms.Button();
            this.but_other = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_but
            // 
            this.customer_but.BackColor = System.Drawing.SystemColors.Control;
            this.customer_but.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.customer_but.ForeColor = System.Drawing.SystemColors.MenuText;
            this.customer_but.Location = new System.Drawing.Point(12, 12);
            this.customer_but.Name = "customer_but";
            this.customer_but.Size = new System.Drawing.Size(248, 109);
            this.customer_but.TabIndex = 0;
            this.customer_but.Text = "MÜŞTERİ";
            this.customer_but.UseVisualStyleBackColor = false;
            this.customer_but.Click += new System.EventHandler(this.but_customer_Click);
            // 
            // but_rep
            // 
            this.but_rep.BackColor = System.Drawing.SystemColors.Control;
            this.but_rep.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.but_rep.ForeColor = System.Drawing.Color.DarkCyan;
            this.but_rep.Location = new System.Drawing.Point(12, 127);
            this.but_rep.Name = "but_rep";
            this.but_rep.Size = new System.Drawing.Size(248, 109);
            this.but_rep.TabIndex = 1;
            this.but_rep.Text = "MÜŞTERİ TEMSİLCİSİ";
            this.but_rep.UseVisualStyleBackColor = false;
            // 
            // but_bankmanager
            // 
            this.but_bankmanager.BackColor = System.Drawing.SystemColors.Control;
            this.but_bankmanager.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.but_bankmanager.ForeColor = System.Drawing.Color.Crimson;
            this.but_bankmanager.Location = new System.Drawing.Point(12, 242);
            this.but_bankmanager.Name = "but_bankmanager";
            this.but_bankmanager.Size = new System.Drawing.Size(248, 109);
            this.but_bankmanager.TabIndex = 2;
            this.but_bankmanager.Text = "BANKA MÜDÜRÜ";
            this.but_bankmanager.UseVisualStyleBackColor = false;
            // 
            // but_other
            // 
            this.but_other.Location = new System.Drawing.Point(12, 367);
            this.but_other.Name = "but_other";
            this.but_other.Size = new System.Drawing.Size(22, 23);
            this.but_other.TabIndex = 3;
            this.but_other.Text = "X";
            this.but_other.UseVisualStyleBackColor = true;
            this.but_other.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 402);
            this.Controls.Add(this.but_other);
            this.Controls.Add(this.but_bankmanager);
            this.Controls.Add(this.but_rep);
            this.Controls.Add(this.customer_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.Text = "BANKA";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_but;
        private System.Windows.Forms.Button but_rep;
        private System.Windows.Forms.Button but_bankmanager;
        private System.Windows.Forms.Button but_other;
    }
}

