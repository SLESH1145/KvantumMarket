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
        List<string> links = new List<string>();
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
            links.Add($"https://www.eldorado.ru/search/catalog.php?q={search}");
            //links.Add($"https://www.onlinetrade.ru/sitesearch.html?query={search}");
            //links.Add($"https://www.citilink.ru/search/?text={search}");
            //links.Add($"https://market.yandex.ru/search?text={search}"); 

            scraper.StartAsync();
            //links.Clear();
            Console.WriteLine(search);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info_eld.Text = $"Товар: \n\n\n\n\nЦена:";
            info_siti.Text = $"Товар: \n\n\n\n\nЦена:";
            scraper = new BlogScraper(links);
        }
    }
}
