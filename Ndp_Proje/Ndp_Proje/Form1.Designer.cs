namespace Ndp_Proje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.organikAtıkListBox = new System.Windows.Forms.ListBox();
            this.organikAtıkBosaltButton = new System.Windows.Forms.Button();
            this.organikProgress = new System.Windows.Forms.ProgressBar();
            this.organikAtıkGroupBox = new System.Windows.Forms.GroupBox();
            this.organikAtıkButton = new System.Windows.Forms.Button();
            this.kagıtGroupBox = new System.Windows.Forms.GroupBox();
            this.kagıtButton = new System.Windows.Forms.Button();
            this.kagitProgress = new System.Windows.Forms.ProgressBar();
            this.kagıtBosaltButton = new System.Windows.Forms.Button();
            this.kagıtListBox = new System.Windows.Forms.ListBox();
            this.camGroupBox = new System.Windows.Forms.GroupBox();
            this.camButton = new System.Windows.Forms.Button();
            this.camProgress = new System.Windows.Forms.ProgressBar();
            this.camBosaltButton = new System.Windows.Forms.Button();
            this.camListBox = new System.Windows.Forms.ListBox();
            this.metalGroupBox = new System.Windows.Forms.GroupBox();
            this.metalButton = new System.Windows.Forms.Button();
            this.metalProgress = new System.Windows.Forms.ProgressBar();
            this.metalBosaltButton = new System.Windows.Forms.Button();
            this.metalListBox = new System.Windows.Forms.ListBox();
            this.yeniOyunButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.puanLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.atikPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sureLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.organikAtıkGroupBox.SuspendLayout();
            this.kagıtGroupBox.SuspendLayout();
            this.camGroupBox.SuspendLayout();
            this.metalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atikPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // organikAtıkListBox
            // 
            this.organikAtıkListBox.FormattingEnabled = true;
            this.organikAtıkListBox.ItemHeight = 16;
            this.organikAtıkListBox.Location = new System.Drawing.Point(6, 47);
            this.organikAtıkListBox.Name = "organikAtıkListBox";
            this.organikAtıkListBox.Size = new System.Drawing.Size(130, 196);
            this.organikAtıkListBox.TabIndex = 0;
            // 
            // organikAtıkBosaltButton
            // 
            this.organikAtıkBosaltButton.BackColor = System.Drawing.Color.White;
            this.organikAtıkBosaltButton.Location = new System.Drawing.Point(4, 271);
            this.organikAtıkBosaltButton.Name = "organikAtıkBosaltButton";
            this.organikAtıkBosaltButton.Size = new System.Drawing.Size(131, 31);
            this.organikAtıkBosaltButton.TabIndex = 2;
            this.organikAtıkBosaltButton.Text = "BOŞALT";
            this.organikAtıkBosaltButton.UseVisualStyleBackColor = false;
            this.organikAtıkBosaltButton.Click += new System.EventHandler(this.organikAtıkBosaltButton_Click);
            // 
            // organikProgress
            // 
            this.organikProgress.Location = new System.Drawing.Point(6, 249);
            this.organikProgress.Name = "organikProgress";
            this.organikProgress.Size = new System.Drawing.Size(130, 16);
            this.organikProgress.TabIndex = 3;
            // 
            // organikAtıkGroupBox
            // 
            this.organikAtıkGroupBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.organikAtıkGroupBox.Controls.Add(this.organikAtıkButton);
            this.organikAtıkGroupBox.Controls.Add(this.organikProgress);
            this.organikAtıkGroupBox.Controls.Add(this.organikAtıkBosaltButton);
            this.organikAtıkGroupBox.Controls.Add(this.organikAtıkListBox);
            this.organikAtıkGroupBox.Location = new System.Drawing.Point(214, 44);
            this.organikAtıkGroupBox.Name = "organikAtıkGroupBox";
            this.organikAtıkGroupBox.Size = new System.Drawing.Size(142, 313);
            this.organikAtıkGroupBox.TabIndex = 4;
            this.organikAtıkGroupBox.TabStop = false;
            // 
            // organikAtıkButton
            // 
            this.organikAtıkButton.BackColor = System.Drawing.Color.White;
            this.organikAtıkButton.Location = new System.Drawing.Point(6, 18);
            this.organikAtıkButton.Name = "organikAtıkButton";
            this.organikAtıkButton.Size = new System.Drawing.Size(130, 23);
            this.organikAtıkButton.TabIndex = 4;
            this.organikAtıkButton.Text = "ORGANİK ATIK";
            this.organikAtıkButton.UseVisualStyleBackColor = false;
            this.organikAtıkButton.Click += new System.EventHandler(this.organikAtıkButton_Click);
            // 
            // kagıtGroupBox
            // 
            this.kagıtGroupBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.kagıtGroupBox.Controls.Add(this.kagıtButton);
            this.kagıtGroupBox.Controls.Add(this.kagitProgress);
            this.kagıtGroupBox.Controls.Add(this.kagıtBosaltButton);
            this.kagıtGroupBox.Controls.Add(this.kagıtListBox);
            this.kagıtGroupBox.Location = new System.Drawing.Point(373, 44);
            this.kagıtGroupBox.Name = "kagıtGroupBox";
            this.kagıtGroupBox.Size = new System.Drawing.Size(145, 313);
            this.kagıtGroupBox.TabIndex = 5;
            this.kagıtGroupBox.TabStop = false;
            // 
            // kagıtButton
            // 
            this.kagıtButton.BackColor = System.Drawing.Color.White;
            this.kagıtButton.Location = new System.Drawing.Point(6, 18);
            this.kagıtButton.Name = "kagıtButton";
            this.kagıtButton.Size = new System.Drawing.Size(130, 23);
            this.kagıtButton.TabIndex = 5;
            this.kagıtButton.Text = "KAĞIT";
            this.kagıtButton.UseVisualStyleBackColor = false;
            this.kagıtButton.Click += new System.EventHandler(this.kagıtButton_Click);
            // 
            // kagitProgress
            // 
            this.kagitProgress.Location = new System.Drawing.Point(6, 249);
            this.kagitProgress.Name = "kagitProgress";
            this.kagitProgress.Size = new System.Drawing.Size(130, 16);
            this.kagitProgress.TabIndex = 3;
            // 
            // kagıtBosaltButton
            // 
            this.kagıtBosaltButton.BackColor = System.Drawing.Color.White;
            this.kagıtBosaltButton.Location = new System.Drawing.Point(6, 271);
            this.kagıtBosaltButton.Name = "kagıtBosaltButton";
            this.kagıtBosaltButton.Size = new System.Drawing.Size(130, 31);
            this.kagıtBosaltButton.TabIndex = 2;
            this.kagıtBosaltButton.Text = "BOŞALT";
            this.kagıtBosaltButton.UseVisualStyleBackColor = false;
            this.kagıtBosaltButton.Click += new System.EventHandler(this.kagıtBosaltButton_Click);
            // 
            // kagıtListBox
            // 
            this.kagıtListBox.ItemHeight = 16;
            this.kagıtListBox.Location = new System.Drawing.Point(6, 47);
            this.kagıtListBox.Name = "kagıtListBox";
            this.kagıtListBox.Size = new System.Drawing.Size(130, 196);
            this.kagıtListBox.TabIndex = 0;
            // 
            // camGroupBox
            // 
            this.camGroupBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.camGroupBox.Controls.Add(this.camButton);
            this.camGroupBox.Controls.Add(this.camProgress);
            this.camGroupBox.Controls.Add(this.camBosaltButton);
            this.camGroupBox.Controls.Add(this.camListBox);
            this.camGroupBox.Location = new System.Drawing.Point(213, 363);
            this.camGroupBox.Name = "camGroupBox";
            this.camGroupBox.Size = new System.Drawing.Size(143, 309);
            this.camGroupBox.TabIndex = 6;
            this.camGroupBox.TabStop = false;
            // 
            // camButton
            // 
            this.camButton.BackColor = System.Drawing.Color.White;
            this.camButton.Location = new System.Drawing.Point(6, 19);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(130, 23);
            this.camButton.TabIndex = 5;
            this.camButton.Text = "CAM";
            this.camButton.UseVisualStyleBackColor = false;
            this.camButton.Click += new System.EventHandler(this.camButton_Click);
            // 
            // camProgress
            // 
            this.camProgress.Location = new System.Drawing.Point(6, 249);
            this.camProgress.Name = "camProgress";
            this.camProgress.Size = new System.Drawing.Size(130, 16);
            this.camProgress.TabIndex = 3;
            // 
            // camBosaltButton
            // 
            this.camBosaltButton.BackColor = System.Drawing.Color.White;
            this.camBosaltButton.Location = new System.Drawing.Point(6, 271);
            this.camBosaltButton.Name = "camBosaltButton";
            this.camBosaltButton.Size = new System.Drawing.Size(130, 31);
            this.camBosaltButton.TabIndex = 2;
            this.camBosaltButton.Text = "BOŞALT";
            this.camBosaltButton.UseVisualStyleBackColor = false;
            this.camBosaltButton.Click += new System.EventHandler(this.camBosaltButton_Click);
            // 
            // camListBox
            // 
            this.camListBox.FormattingEnabled = true;
            this.camListBox.ItemHeight = 16;
            this.camListBox.Location = new System.Drawing.Point(6, 47);
            this.camListBox.Name = "camListBox";
            this.camListBox.Size = new System.Drawing.Size(130, 196);
            this.camListBox.TabIndex = 0;
            // 
            // metalGroupBox
            // 
            this.metalGroupBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metalGroupBox.Controls.Add(this.metalButton);
            this.metalGroupBox.Controls.Add(this.metalProgress);
            this.metalGroupBox.Controls.Add(this.metalBosaltButton);
            this.metalGroupBox.Controls.Add(this.metalListBox);
            this.metalGroupBox.Location = new System.Drawing.Point(373, 363);
            this.metalGroupBox.Name = "metalGroupBox";
            this.metalGroupBox.Size = new System.Drawing.Size(145, 311);
            this.metalGroupBox.TabIndex = 7;
            this.metalGroupBox.TabStop = false;
            // 
            // metalButton
            // 
            this.metalButton.BackColor = System.Drawing.Color.White;
            this.metalButton.Location = new System.Drawing.Point(6, 18);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(133, 23);
            this.metalButton.TabIndex = 5;
            this.metalButton.Text = "METAL";
            this.metalButton.UseVisualStyleBackColor = false;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // metalProgress
            // 
            this.metalProgress.Location = new System.Drawing.Point(6, 249);
            this.metalProgress.Name = "metalProgress";
            this.metalProgress.Size = new System.Drawing.Size(127, 16);
            this.metalProgress.TabIndex = 3;
            // 
            // metalBosaltButton
            // 
            this.metalBosaltButton.BackColor = System.Drawing.Color.White;
            this.metalBosaltButton.Location = new System.Drawing.Point(6, 271);
            this.metalBosaltButton.Name = "metalBosaltButton";
            this.metalBosaltButton.Size = new System.Drawing.Size(127, 31);
            this.metalBosaltButton.TabIndex = 2;
            this.metalBosaltButton.Text = "BOŞALT";
            this.metalBosaltButton.UseVisualStyleBackColor = false;
            this.metalBosaltButton.Click += new System.EventHandler(this.metalBosaltButton_Click);
            // 
            // metalListBox
            // 
            this.metalListBox.FormattingEnabled = true;
            this.metalListBox.ItemHeight = 16;
            this.metalListBox.Location = new System.Drawing.Point(6, 47);
            this.metalListBox.Name = "metalListBox";
            this.metalListBox.Size = new System.Drawing.Size(130, 196);
            this.metalListBox.TabIndex = 0;
            // 
            // yeniOyunButton
            // 
            this.yeniOyunButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.yeniOyunButton.ForeColor = System.Drawing.Color.White;
            this.yeniOyunButton.Location = new System.Drawing.Point(14, 19);
            this.yeniOyunButton.Name = "yeniOyunButton";
            this.yeniOyunButton.Size = new System.Drawing.Size(154, 57);
            this.yeniOyunButton.TabIndex = 8;
            this.yeniOyunButton.Text = "YENİ OYUN";
            this.yeniOyunButton.UseVisualStyleBackColor = false;
            this.yeniOyunButton.Click += new System.EventHandler(this.yeniOyunButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "SÜRE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puanLabel
            // 
            this.puanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.ForeColor = System.Drawing.Color.Black;
            this.puanLabel.Location = new System.Drawing.Point(14, 234);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(154, 57);
            this.puanLabel.TabIndex = 12;
            this.puanLabel.Text = "0";
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "PUAN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cikisButton.ForeColor = System.Drawing.Color.White;
            this.cikisButton.Location = new System.Drawing.Point(14, 318);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(154, 57);
            this.cikisButton.TabIndex = 13;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // atikPictureBox
            // 
            this.atikPictureBox.BackColor = System.Drawing.Color.White;
            this.atikPictureBox.Location = new System.Drawing.Point(16, 22);
            this.atikPictureBox.Name = "atikPictureBox";
            this.atikPictureBox.Size = new System.Drawing.Size(154, 210);
            this.atikPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atikPictureBox.TabIndex = 14;
            this.atikPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.sureLabel);
            this.groupBox1.Controls.Add(this.cikisButton);
            this.groupBox1.Controls.Add(this.puanLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.yeniOyunButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 391);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // sureLabel
            // 
            this.sureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.ForeColor = System.Drawing.Color.Black;
            this.sureLabel.Location = new System.Drawing.Point(14, 131);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(154, 57);
            this.sureLabel.TabIndex = 14;
            this.sureLabel.Text = "60";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.atikPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(24, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 257);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(214, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "ATIK KUTULARI";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(538, 675);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metalGroupBox);
            this.Controls.Add(this.camGroupBox);
            this.Controls.Add(this.kagıtGroupBox);
            this.Controls.Add(this.organikAtıkGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atık Kutuları";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.organikAtıkGroupBox.ResumeLayout(false);
            this.kagıtGroupBox.ResumeLayout(false);
            this.camGroupBox.ResumeLayout(false);
            this.metalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atikPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox organikAtıkListBox;
        private System.Windows.Forms.Button organikAtıkBosaltButton;
        private System.Windows.Forms.ProgressBar organikProgress;
        private System.Windows.Forms.GroupBox organikAtıkGroupBox;
        private System.Windows.Forms.GroupBox kagıtGroupBox;
        private System.Windows.Forms.ProgressBar kagitProgress;
        private System.Windows.Forms.Button kagıtBosaltButton;
        private System.Windows.Forms.GroupBox camGroupBox;
        private System.Windows.Forms.ProgressBar camProgress;
        private System.Windows.Forms.Button camBosaltButton;
        private System.Windows.Forms.ListBox camListBox;
        private System.Windows.Forms.GroupBox metalGroupBox;
        private System.Windows.Forms.ProgressBar metalProgress;
        private System.Windows.Forms.Button metalBosaltButton;
        private System.Windows.Forms.ListBox metalListBox;
        private System.Windows.Forms.Button yeniOyunButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.PictureBox atikPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button organikAtıkButton;
        private System.Windows.Forms.Button kagıtButton;
        private System.Windows.Forms.Button camButton;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.ListBox kagıtListBox;
    }
}

