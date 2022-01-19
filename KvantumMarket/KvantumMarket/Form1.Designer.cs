
namespace KvantumMarket
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_string = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.info_siti = new System.Windows.Forms.Label();
            this.img_siti = new System.Windows.Forms.PictureBox();
            this.info_eld = new System.Windows.Forms.Label();
            this.img_eld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_siti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eld)).BeginInit();
            this.SuspendLayout();
            // 
            // search_string
            // 
            this.search_string.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.search_string.Location = new System.Drawing.Point(228, 24);
            this.search_string.Name = "search_string";
            this.search_string.Size = new System.Drawing.Size(374, 20);
            this.search_string.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(598, 24);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(44, 20);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "start";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(383, 312);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(294, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // info_siti
            // 
            this.info_siti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info_siti.Location = new System.Drawing.Point(12, 89);
            this.info_siti.Name = "info_siti";
            this.info_siti.Size = new System.Drawing.Size(294, 190);
            this.info_siti.TabIndex = 8;
            // 
            // img_siti
            // 
            this.img_siti.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.img_siti.Location = new System.Drawing.Point(175, 89);
            this.img_siti.Name = "img_siti";
            this.img_siti.Size = new System.Drawing.Size(131, 190);
            this.img_siti.TabIndex = 9;
            this.img_siti.TabStop = false;
            // 
            // info_eld
            // 
            this.info_eld.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info_eld.Location = new System.Drawing.Point(383, 89);
            this.info_eld.Name = "info_eld";
            this.info_eld.Size = new System.Drawing.Size(294, 190);
            this.info_eld.TabIndex = 10;
            // 
            // img_eld
            // 
            this.img_eld.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.img_eld.Location = new System.Drawing.Point(546, 89);
            this.img_eld.Name = "img_eld";
            this.img_eld.Size = new System.Drawing.Size(131, 190);
            this.img_eld.TabIndex = 11;
            this.img_eld.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 505);
            this.Controls.Add(this.img_eld);
            this.Controls.Add(this.info_eld);
            this.Controls.Add(this.img_siti);
            this.Controls.Add(this.info_siti);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.search_string);
            this.Name = "Form1";
            this.Text = "KvantumMarket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_siti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_string;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label info_siti;
        private System.Windows.Forms.PictureBox img_siti;
        private System.Windows.Forms.Label info_eld;
        private System.Windows.Forms.PictureBox img_eld;
    }
}

