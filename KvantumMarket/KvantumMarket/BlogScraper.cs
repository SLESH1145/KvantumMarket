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
        public string search; 
        public BlogScraper()
        {
            ObeyRobotsDotTxt = false;           
        }
        public void Search(string searh1)
        {
            search = searh1;
        }
        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;
            Console.WriteLine(search);
            //this.Request($"https://www.eldorado.ru/search/catalog.php?q=", Parse );
            this.Request($"https://www.eldorado.ru/search/catalog.php?q={search}&utf", Parse);
        }
        public override void Parse(Response response)
        {
            foreach (var title_link in response.XPath("//div[@id='listing-container']/ul/li"))
            {
                string strTitle = title_link.TextContentClean;
                //string strTitle = title_link.TextContentClean;
                Scrape(new ScrapedData() { { "sadf", strTitle } });
            }

        }
    }
}
