namespace WindowsFormsApp2
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
            this.scoreText = new System.Windows.Forms.Label();
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.Kuş = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.highestScoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kuş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(12, 18);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(119, 25);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "SCORE : 0";
            // 
            // boruUst
            // 
            this.boruUst.Image = ((System.Drawing.Image)(resources.GetObject("boruUst.Image")));
            this.boruUst.Location = new System.Drawing.Point(539, -250);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(102, 515);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 1;
            this.boruUst.TabStop = false;
            // 
            // Kuş
            // 
            this.Kuş.Image = ((System.Drawing.Image)(resources.GetObject("Kuş.Image")));
            this.Kuş.Location = new System.Drawing.Point(66, 299);
            this.Kuş.Name = "Kuş";
            this.Kuş.Size = new System.Drawing.Size(84, 92);
            this.Kuş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kuş.TabIndex = 1;
            this.Kuş.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-6, 767);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(1049, 104);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 1;
            this.Zemin.TabStop = false;
            // 
            // boruAlt
            // 
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(469, 521);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(120, 470);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 1;
            this.boruAlt.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // highestScoreText
            // 
            this.highestScoreText.AutoSize = true;
            this.highestScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highestScoreText.Location = new System.Drawing.Point(13, 56);
            this.highestScoreText.Name = "highestScoreText";
            this.highestScoreText.Size = new System.Drawing.Size(192, 22);
            this.highestScoreText.TabIndex = 2;
            this.highestScoreText.Text = "En Yüksek Score : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(774, 883);
            this.Controls.Add(this.highestScoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Kuş);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruUst);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kuş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.PictureBox Kuş;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label highestScoreText;
    }
}

