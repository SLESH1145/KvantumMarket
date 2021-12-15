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
        public Form1()
        {
            InitializeComponent();
        }
                                
        private void button_search_Click(object sender, EventArgs e)
        {       
            string search = search_string.Text;
            //links.Add($"https://www.eldorado.ru/search/catalog.php?q={search}");
            links.Add($"https://www.onlinetrade.ru/sitesearch.html?query={search}");
            links.Add($"https://www.citilink.ru/search/?text={search}");       
            //links.Add($"https://market.yandex.ru/search?text={search}");       
            scraper.StartAsync();
            Console.WriteLine("asdsad");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           scraper = new BlogScraper(links);
            

        }
    }
}
