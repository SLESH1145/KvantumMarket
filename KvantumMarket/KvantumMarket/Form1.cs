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
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button_search_Click(object sender, EventArgs e)
        {            
            BlogScraper scraper = new BlogScraper();
            string search = search_string.Text;
            string search_link_eld = $"https://www.eldorado.ru/search/catalog.php?q={search}";
            scraper.Search(search_link_eld);
            scraper.Start();
        }
        
        
    }
}
