
namespace KvantumMarket
{
    partial class KvantuMarket
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
            this.components = new System.ComponentModel.Container();
            this.search_string = new System.Windows.Forms.TextBox();
            this.start_search = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.best_price = new System.Windows.Forms.Label();
            this.best_link = new System.Windows.Forms.LinkLabel();
            this.best_info = new System.Windows.Forms.Label();
            this.inf_box1 = new System.Windows.Forms.Label();
            this.link_1 = new System.Windows.Forms.LinkLabel();
            this.price_1 = new System.Windows.Forms.Label();
            this.link_2 = new System.Windows.Forms.LinkLabel();
            this.price_2 = new System.Windows.Forms.Label();
            this.name_2 = new System.Windows.Forms.Label();
            this.link_3 = new System.Windows.Forms.LinkLabel();
            this.price_3 = new System.Windows.Forms.Label();
            this.name_3 = new System.Windows.Forms.Label();
            this.link_4 = new System.Windows.Forms.LinkLabel();
            this.price_4 = new System.Windows.Forms.Label();
            this.name_4 = new System.Windows.Forms.Label();
            this.link_5 = new System.Windows.Forms.LinkLabel();
            this.price_5 = new System.Windows.Forms.Label();
            this.name_5 = new System.Windows.Forms.Label();
            this.img_5 = new System.Windows.Forms.PictureBox();
            this.img_4 = new System.Windows.Forms.PictureBox();
            this.img_3 = new System.Windows.Forms.PictureBox();
            this.img_2 = new System.Windows.Forms.PictureBox();
            this.img_1 = new System.Windows.Forms.PictureBox();
            this.best_img = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.img_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.best_img)).BeginInit();
            this.SuspendLayout();
            // 
            // search_string
            // 
            this.search_string.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_string.Location = new System.Drawing.Point(416, 32);
            this.search_string.Name = "search_string";
            this.search_string.Size = new System.Drawing.Size(333, 21);
            this.search_string.TabIndex = 0;
            // 
            // start_search
            // 
            this.start_search.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.start_search.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_search.Location = new System.Drawing.Point(735, 32);
            this.start_search.Name = "start_search";
            this.start_search.Size = new System.Drawing.Size(63, 23);
            this.start_search.TabIndex = 1;
            this.start_search.Text = "search";
            this.start_search.UseVisualStyleBackColor = true;
            this.start_search.Click += new System.EventHandler(this.start_search_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(388, 58);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(439, 44);
            this.title.TabIndex = 4;
            // 
            // best_price
            // 
            this.best_price.AutoSize = true;
            this.best_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best_price.Location = new System.Drawing.Point(12, 104);
            this.best_price.Name = "best_price";
            this.best_price.Size = new System.Drawing.Size(0, 21);
            this.best_price.TabIndex = 5;
            // 
            // best_link
            // 
            this.best_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best_link.Location = new System.Drawing.Point(13, 317);
            this.best_link.Name = "best_link";
            this.best_link.Size = new System.Drawing.Size(312, 22);
            this.best_link.TabIndex = 6;
            this.best_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.best_link_LinkClicked);
            // 
            // best_info
            // 
            this.best_info.BackColor = System.Drawing.SystemColors.HighlightText;
            this.best_info.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best_info.Location = new System.Drawing.Point(148, 144);
            this.best_info.Name = "best_info";
            this.best_info.Size = new System.Drawing.Size(177, 155);
            this.best_info.TabIndex = 9;
            // 
            // inf_box1
            // 
            this.inf_box1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inf_box1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf_box1.Location = new System.Drawing.Point(551, 144);
            this.inf_box1.Name = "inf_box1";
            this.inf_box1.Size = new System.Drawing.Size(361, 58);
            this.inf_box1.TabIndex = 10;
            // 
            // link_1
            // 
            this.link_1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.link_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_1.Location = new System.Drawing.Point(551, 202);
            this.link_1.Name = "link_1";
            this.link_1.Size = new System.Drawing.Size(464, 22);
            this.link_1.TabIndex = 12;
            this.link_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_1_LinkClicked);
            // 
            // price_1
            // 
            this.price_1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price_1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.price_1.Location = new System.Drawing.Point(906, 144);
            this.price_1.Name = "price_1";
            this.price_1.Size = new System.Drawing.Size(109, 58);
            this.price_1.TabIndex = 11;
            this.price_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_2
            // 
            this.link_2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.link_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_2.Location = new System.Drawing.Point(551, 299);
            this.link_2.Name = "link_2";
            this.link_2.Size = new System.Drawing.Size(464, 22);
            this.link_2.TabIndex = 19;
            this.link_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_2_LinkClicked);
            // 
            // price_2
            // 
            this.price_2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price_2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_2.Location = new System.Drawing.Point(906, 241);
            this.price_2.Name = "price_2";
            this.price_2.Size = new System.Drawing.Size(109, 58);
            this.price_2.TabIndex = 18;
            this.price_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_2
            // 
            this.name_2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name_2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_2.Location = new System.Drawing.Point(550, 241);
            this.name_2.Name = "name_2";
            this.name_2.Size = new System.Drawing.Size(361, 58);
            this.name_2.TabIndex = 17;
            // 
            // link_3
            // 
            this.link_3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.link_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_3.Location = new System.Drawing.Point(551, 393);
            this.link_3.Name = "link_3";
            this.link_3.Size = new System.Drawing.Size(464, 22);
            this.link_3.TabIndex = 23;
            this.link_3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_3_LinkClicked);
            // 
            // price_3
            // 
            this.price_3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price_3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_3.Location = new System.Drawing.Point(906, 335);
            this.price_3.Name = "price_3";
            this.price_3.Size = new System.Drawing.Size(109, 58);
            this.price_3.TabIndex = 22;
            this.price_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_3
            // 
            this.name_3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name_3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_3.Location = new System.Drawing.Point(551, 335);
            this.name_3.Name = "name_3";
            this.name_3.Size = new System.Drawing.Size(361, 58);
            this.name_3.TabIndex = 21;
            // 
            // link_4
            // 
            this.link_4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.link_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_4.Location = new System.Drawing.Point(551, 487);
            this.link_4.Name = "link_4";
            this.link_4.Size = new System.Drawing.Size(464, 22);
            this.link_4.TabIndex = 27;
            this.link_4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_4_LinkClicked);
            // 
            // price_4
            // 
            this.price_4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price_4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_4.Location = new System.Drawing.Point(906, 429);
            this.price_4.Name = "price_4";
            this.price_4.Size = new System.Drawing.Size(109, 58);
            this.price_4.TabIndex = 26;
            this.price_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_4
            // 
            this.name_4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name_4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_4.Location = new System.Drawing.Point(551, 429);
            this.name_4.Name = "name_4";
            this.name_4.Size = new System.Drawing.Size(361, 58);
            this.name_4.TabIndex = 25;
            // 
            // link_5
            // 
            this.link_5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.link_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_5.Location = new System.Drawing.Point(550, 579);
            this.link_5.Name = "link_5";
            this.link_5.Size = new System.Drawing.Size(464, 22);
            this.link_5.TabIndex = 31;
            this.link_5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_5_LinkClicked);
            // 
            // price_5
            // 
            this.price_5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price_5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_5.Location = new System.Drawing.Point(905, 521);
            this.price_5.Name = "price_5";
            this.price_5.Size = new System.Drawing.Size(109, 58);
            this.price_5.TabIndex = 30;
            this.price_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_5
            // 
            this.name_5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name_5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_5.Location = new System.Drawing.Point(550, 521);
            this.name_5.Name = "name_5";
            this.name_5.Size = new System.Drawing.Size(361, 58);
            this.name_5.TabIndex = 29;
            // 
            // img_5
            // 
            this.img_5.ImageLocation = "";
            this.img_5.Location = new System.Drawing.Point(457, 521);
            this.img_5.Name = "img_5";
            this.img_5.Size = new System.Drawing.Size(87, 80);
            this.img_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_5.TabIndex = 32;
            this.img_5.TabStop = false;
            // 
            // img_4
            // 
            this.img_4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.img_4.ImageLocation = "";
            this.img_4.Location = new System.Drawing.Point(458, 429);
            this.img_4.Name = "img_4";
            this.img_4.Size = new System.Drawing.Size(87, 80);
            this.img_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_4.TabIndex = 28;
            this.img_4.TabStop = false;
            // 
            // img_3
            // 
            this.img_3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.img_3.ImageLocation = "";
            this.img_3.Location = new System.Drawing.Point(458, 335);
            this.img_3.Name = "img_3";
            this.img_3.Size = new System.Drawing.Size(87, 80);
            this.img_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_3.TabIndex = 24;
            this.img_3.TabStop = false;
            // 
            // img_2
            // 
            this.img_2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.img_2.ImageLocation = "";
            this.img_2.Location = new System.Drawing.Point(458, 241);
            this.img_2.Name = "img_2";
            this.img_2.Size = new System.Drawing.Size(87, 80);
            this.img_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_2.TabIndex = 20;
            this.img_2.TabStop = false;
            // 
            // img_1
            // 
            this.img_1.ImageLocation = "";
            this.img_1.Location = new System.Drawing.Point(458, 144);
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(87, 80);
            this.img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_1.TabIndex = 13;
            this.img_1.TabStop = false;
            // 
            // best_img
            // 
            this.best_img.Location = new System.Drawing.Point(16, 144);
            this.best_img.Name = "best_img";
            this.best_img.Size = new System.Drawing.Size(126, 155);
            this.best_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.best_img.TabIndex = 8;
            this.best_img.TabStop = false;
            // 
            // timer1
            // 

            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar1.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar1.Location = new System.Drawing.Point(12, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(224, 25);
            this.progressBar1.TabIndex = 33;
            // 
            // KvantuMarket
            // 
            this.AcceptButton = this.start_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1177, 635);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.img_5);
            this.Controls.Add(this.link_5);
            this.Controls.Add(this.price_5);
            this.Controls.Add(this.name_5);
            this.Controls.Add(this.img_4);
            this.Controls.Add(this.link_4);
            this.Controls.Add(this.price_4);
            this.Controls.Add(this.name_4);
            this.Controls.Add(this.img_3);
            this.Controls.Add(this.link_3);
            this.Controls.Add(this.price_3);
            this.Controls.Add(this.name_3);
            this.Controls.Add(this.img_2);
            this.Controls.Add(this.link_2);
            this.Controls.Add(this.price_2);
            this.Controls.Add(this.name_2);
            this.Controls.Add(this.img_1);
            this.Controls.Add(this.link_1);
            this.Controls.Add(this.price_1);
            this.Controls.Add(this.inf_box1);
            this.Controls.Add(this.best_info);
            this.Controls.Add(this.best_img);
            this.Controls.Add(this.best_link);
            this.Controls.Add(this.best_price);
            this.Controls.Add(this.title);
            this.Controls.Add(this.start_search);
            this.Controls.Add(this.search_string);
            this.Name = "KvantuMarket";
            this.Text = "Kvantum Market";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.best_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_string;
        private System.Windows.Forms.Button start_search;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label best_price;
        private System.Windows.Forms.LinkLabel best_link;
        private System.Windows.Forms.PictureBox best_img;
        private System.Windows.Forms.Label best_info;
        private System.Windows.Forms.Label inf_box1;
        private System.Windows.Forms.LinkLabel link_1;
        private System.Windows.Forms.PictureBox img_1;
        private System.Windows.Forms.Label price_1;
        private System.Windows.Forms.PictureBox img_2;
        private System.Windows.Forms.LinkLabel link_2;
        private System.Windows.Forms.Label price_2;
        private System.Windows.Forms.Label name_2;
        private System.Windows.Forms.PictureBox img_3;
        private System.Windows.Forms.LinkLabel link_3;
        private System.Windows.Forms.Label price_3;
        private System.Windows.Forms.Label name_3;
        private System.Windows.Forms.PictureBox img_4;
        private System.Windows.Forms.LinkLabel link_4;
        private System.Windows.Forms.Label price_4;
        private System.Windows.Forms.Label name_4;
        private System.Windows.Forms.PictureBox img_5;
        private System.Windows.Forms.LinkLabel link_5;
        private System.Windows.Forms.Label price_5;
        private System.Windows.Forms.Label name_5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

