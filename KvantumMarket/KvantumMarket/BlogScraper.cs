using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronWebScraper;
using System.Windows.Forms;

namespace KvantumMarket
{
    class BlogScraper : WebScraper
    {
        public List<string> links = new List<string>();       
        public string xpath_price;
        public string xpath_name;
        public BlogScraper(List<string> links)
        {
            ObeyRobotsDotTxt = false;
            this.links = links;
        }      
        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;                      
            this.Request(links, Parse);
        }

        public void SetXPath(string url)
        {
            if (url.Contains("eldorado.ru"))
            {
                xpath_price = "//div/span[@data-pc='offer_price']";
                xpath_name = "//div/a[@data-dy='title']";
            }
            else if (url.Contains("dns-shop.ru")) 
            {
                xpath_price = "//div[@class='product-buy__price product-buy__price_active']";
                xpath_name = "//a[@class='catalog-product__name ui-link ui-link_black']/span";
            }
            else if (url.Contains("mvideo.ru"))
            {
                xpath_price = "//span[@class='price__main-value']";
                xpath_name = "//a[@class='product-title__text product-title--clamp']";
            }
        }
        public override void Parse(Response response)
        {
            SetXPath(response.FinalUrl);
            
            foreach (var title_link in response.XPath(xpath_price))
            {
                string price_eld = title_link.TextContentClean;
                Console.WriteLine(price_eld);
                break;               
            }

            foreach (var name in response.XPath(xpath_name))
            {
                string name_product_eld = name.TextContentClean;
                Console.WriteLine(name_product_eld);
                MessageBox.Show(name_product_eld);
                break;
            }
        }
    }
}
