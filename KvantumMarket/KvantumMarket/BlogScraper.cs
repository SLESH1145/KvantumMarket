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
            this.Request($"{search}", Parse);
        }
        public override void Parse(Response response)
        {
            foreach (var title_link in response.XPath("//div/span[@data-pc='offer_price']"))
            {
                string price_eld = title_link.TextContentClean;
                Console.WriteLine(price_eld);
                break;               
            }
            foreach (var name in response.XPath("//div/a[@data-dy='title']"))
            {
                string name_product_eld = name.TextContentClean;
                Console.WriteLine(name_product_eld);
                break;
            }
        }
    }
}
