using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronWebScraper;

namespace KvantumMarket
{
    class BlogScraper : WebScraper
    {
        public string search = "смартфон";
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
            this.LoggingLevel = WebScraper.LogLevel.All;
            Console.WriteLine(search);           
            this.Request($"https://www.eldorado.ru/search/catalog.php?q={search}&utf", Parse);
        }
        public override void Parse(Response response)
        {
            foreach (var title_link in response.XPath("//body"))
            {
                string strTitle = title_link.TextContentClean;
                //string strTitle = title_link.TextContentClean;
                Scrape(new ScrapedData() { { "sadf", strTitle } });                
            }

        }
    }
}
