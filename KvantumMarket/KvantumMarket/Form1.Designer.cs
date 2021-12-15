
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
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_string
            // 
            this.search_string.Location = new System.Drawing.Point(259, 24);
            this.search_string.Name = "search_string";
            this.search_string.Size = new System.Drawing.Size(374, 20);
            this.search_string.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(631, 24);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(30, 20);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "button1";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(24, 116);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(238, 159);
            this.info.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 511);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.search_string);
            this.Name = "Form1";
            this.Text = "KvantumMarket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_string;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label info;
    }
}

