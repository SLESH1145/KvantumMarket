using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronWebScraper;

namespace KvantumMarket
{
    public partial class Form1 : Form
    {       
        BlogScraper scraper;
        Dictionary<string, string> dict;
        public string search;
        public Form1()
        {
            InitializeComponent();
        }
        public string FormText(string text)
        {
          return  info_eld.Text = text;
        }
        private void button_search_Click(object sender, EventArgs e)
        {       
            search = search_string.Text;           

            scraper.StartAsync();
            
            Console.WriteLine(search);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dict = new Dictionary<string, string>();
            info_eld.Text = $"Товар: \n\n\n\n\nЦена:";
            info_siti.Text = $"Товар: \n\n\n\n\nЦена:";
            scraper = new BlogScraper();
        }
    }
}
