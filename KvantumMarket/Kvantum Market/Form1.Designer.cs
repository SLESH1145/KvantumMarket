
namespace Kvantum_Market
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
            this.search_string = new System.Windows.Forms.TextBox();
            this.start_search = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.best_price = new System.Windows.Forms.Label();
            this.best_link = new System.Windows.Forms.LinkLabel();
            this.best_info = new System.Windows.Forms.Label();
            this.inf_box1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.best_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.title.Location = new System.Drawing.Point(394, 67);
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
            this.best_info.BackColor = System.Drawing.SystemColors.MenuBar;
            this.best_info.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best_info.Location = new System.Drawing.Point(148, 144);
            this.best_info.Name = "best_info";
            this.best_info.Size = new System.Drawing.Size(177, 155);
            this.best_info.TabIndex = 9;
            // 
            // inf_box1
            // 
            this.inf_box1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inf_box1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf_box1.Location = new System.Drawing.Point(554, 144);
            this.inf_box1.Name = "inf_box1";
            this.inf_box1.Size = new System.Drawing.Size(361, 58);
            this.inf_box1.TabIndex = 10;
            this.inf_box1.Text = "Смартфон Apple iPhone 13 mini 128GB (PRODUCT)RED (MLLY3RU/A)";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(909, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "67999";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(554, 202);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(464, 22);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.eldorado.ru/cat/detail/smartfon-apple-iphone-13-mini-128gb-product-re" +
    "d-mlly3ru-a/";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kvantum_Market.Properties.Resources.Без_имени;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(461, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // best_img
            // 
            this.best_img.Location = new System.Drawing.Point(16, 144);
            this.best_img.Name = "best_img";
            this.best_img.Size = new System.Drawing.Size(126, 155);
            this.best_img.TabIndex = 8;
            this.best_img.TabStop = false;
            // 
            // KvantuMarket
            // 
            this.AcceptButton = this.start_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1177, 635);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

