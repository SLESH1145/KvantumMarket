using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronWebScraper;
using System.Windows.Forms;
using System.Windows.Markup;

namespace KvantumMarket
{
    class BlogScraper : WebScraper
    {
        
        public Dictionary<string,string> result = new Dictionary<string, string>();       
        public string search;
        public BlogScraper()
        {
            ObeyRobotsDotTxt = false;         
        }
        public void Search(string search)
        {
            this.search = search;
        
        }
        public override void Init()
        {
            Console.WriteLine();
            this.LoggingLevel = WebScraper.LogLevel.All;                      
            this.Request($"https://www.e-katalog.ru/ek-list.php?search_={search}", Parse);

        }
        public override void Parse(Response response)
        {
            int i = 1;
            foreach (var title_link in response.XPath("//a[@target='_blank']/u"))
            {
                string market = title_link.TextContentClean;
                MessageBox.Show(market);
                if (i == 7)
                {
                    break;
                }
                else
                    i++;
            }

            foreach (var title_link in response.XPath("//td/a[@rel='nofollow']"))
            {
                string price = title_link.TextContentClean;
                MessageBox.Show(price);
                if (i == 7)
                {
                    break;
                }
                else
                    i++;
            }

        }
    }
}
