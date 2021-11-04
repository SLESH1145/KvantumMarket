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
        BlogScraper scraper = new BlogScraper();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            scraper.Search(search_string.Text);

        }
    }
}
