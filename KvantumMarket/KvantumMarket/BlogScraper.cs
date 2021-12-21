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
        Form1 f = new Form1();
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
            Console.WriteLine();
            this.LoggingLevel = WebScraper.LogLevel.All;                      
            this.Request(links, Parse);

        }
        public void SetXpath(string response)
        {
            if (response.Contains("eldorado.ru"))
            {
                xpath_price = "//div/span[@data-pc='offer_price']";
                xpath_name = "//div/a[@data-dy='title']";

            }
            else if (response.Contains("www.onlinetrade.ru"))
            {
                xpath_price = "//span[@class='price regular']";
                xpath_name = "//a[@class='indexGoods__item__name']";

            }
            else if (response.Contains("www.citilink.ru"))
            {
                xpath_price = "//div[@class='product_data__gtm-js product_data__pageevents-js  ProductCardVertical js--ProductCardInListing ProductCardVertical_normal ProductCardVertical_shadow-hover ProductCardVertical_separated']/div/div[@class='ProductCardVerticalLayout__footer']/div[@class='ProductCardVerticalLayout__wrapper-cart']/div/div/div/div/div[@class='ProductPrice ProductPrice_default ProductCardVerticalPrice__price-current']/span/span";
                xpath_name = "//div[@class='ProductCardVertical__description ']/a[@target='_self']";

            }
        }
        public override void Parse(Response response)
        {
            SetXpath(response.FinalUrl);           
                foreach (var title_link in response.XPath(xpath_price))
                {
                string price_eld = title_link.TextContentClean;
                if (response.FinalUrl.Contains("www.onlinetrade.ru"))
                {                  
                    MessageBox.Show(price_eld + "Онлайн трейд"); 
                    
                }
                if (response.FinalUrl.Contains("eldorado.ru"))
                {
                    string text = $"{price_eld}   eldorado";
                    MessageBox.Show(price_eld + "eldorado");
                    f.FormText(text);
                }              
                if (response.FinalUrl.Contains("www.citilink.ru"))
                {
                    MessageBox.Show(price_eld + "citilink");
                    
                }
                break;
                }
            try
            {
                foreach (var name in response.XPath(xpath_name))
                {

                    string name_product_eld = name.TextContentClean;
                    if (response.FinalUrl.Contains("www.onlinetrade.ru"))
                    {
                        MessageBox.Show(name_product_eld + "Онлайн трейд");
                    }
                    if (response.FinalUrl.Contains("eldorado.ru"))
                    {
                        MessageBox.Show(name_product_eld + "eldorado");
                    }
                    if (response.FinalUrl.Contains("www.citilink.ru"))
                    {
                        MessageBox.Show(name_product_eld + "citilink");
                    }
                    break;

                }               
            }
            catch (System.NullReferenceException)
            {

                MessageBox.Show("Oup-s");
            }
        }
    }
}
