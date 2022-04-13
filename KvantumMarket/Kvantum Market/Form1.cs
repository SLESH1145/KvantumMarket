using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Kvantum_Market
{
    public partial class KvantuMarket : Form
    {
        Dictionary<string, string> item_info_eld;
        Dictionary<string, string> item_info_mv;
        Dictionary<string, string> item_info_dns;
        Dictionary<string, string> item_info_el;
        Dictionary<string, string> item_info_ya;
        Dictionary<string, string> item_info_sb;

        ChromeOptions options = new ChromeOptions();
        ChromeDriver driver;
        WebDriverWait wait;
        Dictionary<string, string> shop_url;

        //https://market.yandex.ru{}/offers?glfilter=25879492%3A25879630_{id}&cpa=1&grhow=supplier&local-offers-first=0&sku=id
        public KvantuMarket()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            shop_url = new Dictionary<string, string>();
            item_info_eld = new Dictionary<string, string>();
            item_info_mv = new Dictionary<string, string>();
            item_info_dns = new Dictionary<string, string>();
            item_info_el = new Dictionary<string, string>();
            item_info_ya = new Dictionary<string, string>();
            item_info_sb = new Dictionary<string, string>();

            #region options


            options.AddArguments("--headless");
            //options.AddArguments("--disable-gpu");            
            options.AddArguments("--disable-javascript");
            options.AddArguments("--disable-plugins");
            options.AddArguments("--disable-java");
            //options.AddArguments("--blink-settings");
            options.AddArguments("user-agent='Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.84 Safari/537.36'");
            //options.AddArguments("--no-sandbox");
            //options.AddArguments("--ignore-certificate-errors");
            //options.AddArguments("--disable-automation");
            //options.AddArguments("--disable-blink-features=AutomationControlled");
            #endregion

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, options);

            
            shop_url.Add("Эльдорадо", "https://www.eldorado.ru/search/catalog.php?q=");
            shop_url.Add("Днс", "https://www.dns-shop.ru/search/?q=");
            shop_url.Add("Мвидео", "https://www.mvideo.ru/product-list-page?q=");
            shop_url.Add("Элекс", "https://elex.ru/search/?q=");
            shop_url.Add("Яндекс", "https://market.yandex.ru/search?cvredirect=2&text=");
            shop_url.Add("Сбер", "https://sbermegamarket.ru/catalog/?q=");



            item_info_eld.Add("name", "//div/a[@data-dy='title']");
            item_info_eld.Add("price", "//div/span[@data-pc='offer_price']");
            item_info_eld.Add("img", "//div[@data-dy='productsList']/a/img");
            item_info_eld.Add("link", "//li/div[@data-dy='productsList']/a");

            item_info_mv.Add("price", "//span[@class='price__main-value']");
            item_info_mv.Add("name", "//div[@class='product-title product-title--grid']/a");
            item_info_mv.Add("img", "//img[@class='product-picture__img product-picture__img--grid']");
            item_info_mv.Add("link", "//div[@class='product-title product-title--grid']/a");

            item_info_dns.Add("price", "//div[@class='product-buy__price']");
            item_info_dns.Add("name", "//div[@data-id='product']/a/span");
            item_info_dns.Add("img", "//div[@data-id='product']/div/a/picture/img");
            item_info_dns.Add("link", "//a[@class='catalog-product__name ui-link ui-link_black']");

            item_info_el.Add("price", "//span[@class='product__new']");
            item_info_el.Add("name", "//a[@class='product__name']");
            item_info_el.Add("img", "//img[@itemprop='image']");
            item_info_el.Add("link", "//div[@class='product__info']/a");

            item_info_ya.Add("price", "//div[@data-zone-name='price']/div/a/div/span/span");
            item_info_ya.Add("name", "//h3[@data-zone-name='title']");
            item_info_ya.Add("img", "//div[@class='_2zfPd']/a/img");
            item_info_ya.Add("link", "//div[@class='_2zfPd']/a");

            item_info_sb.Add("price", "//div[@itemprop='offers']/span");
            item_info_sb.Add("name", "//div[@itemprop='name']/a");
            item_info_sb.Add("img", "//div[@class='item-image item-image_changeable']/a/img");
            item_info_sb.Add("link", "//div[@class='item-image item-image_changeable']/a");

        }

        private void start_search_Click(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> eld_result = new Dictionary<string, string>();
            Dictionary<string, string> sb_result = new Dictionary<string, string>();
            string search = search_string.Text;
            eld_result = get_data(shop_url["Эльдорадо"], search, item_info_eld);
            result.Add("Эльдорадо", eld_result);

            //sb_result = get_data(shop_url["Сбер"], search, item_info_sb);
            //result.Add("Сбер", sb_result);

            inf_eld.Text = $"{result["Эльдорадо"]["name"]}";
            inf_sb.Text = $"{result["Эльдорадо"]["price"]}";

            ////result = get_data(shop_url["Мвидео"], search, item_info_mv);
            ////img_mv.ImageLocation = $"{result["img"]}";
            ////inf_mv.Text = $"{result["name"]}" + Environment.NewLine + $"{result["price"]}";
            ////result.Clear();
            //result = get_data(shop_url["Элекс"], search, item_info_el);
            ////img_el.ImageLocation = $"{result["img"]}";
            //inf_el.Text = $"{result["name"]}" + Environment.NewLine + $"{result["price"]}";
            //result.Clear();
            //result = get_data(shop_url["Яндекс"], search, item_info_ya);
            ////img_ya.ImageLocation = $"{result["img"]}";
            //inf_ya.Text = $"{result["name"]}" + Environment.NewLine + $"{result["price"]}";
            //result.Clear();
            //result = get_data(shop_url["Сбер"], search, item_info_sb);
            ////img_sb.ImageLocation = $"{result["img"]}";
            //inf_sb.Text = $"{result["name"]}" + Environment.NewLine + $"{result["price"]}";
            //result.Clear();
            ////result = get_data(shop_url["Днс"], search, item_info_dns);
            ////foreach (string item in result)
            ////{
            ////    textBox2.Text += item + Environment.NewLine;
            ////}
            #region price.ru
            //driver.Navigate().GoToUrl("https://price.ru/naushniki/apple-airpods-max/");
            //Thread.Sleep(1000);
            ////driver.Navigate().GoToUrl( driver.FindElement(By.XPath("//div[@class='reg-btn-container p-card__button medium full']/a")).GetAttribute("href"));
            //    var next_page = driver.FindElement(By.XPath("//li[@class='element-wrap control next']"));
            //    var pages = driver.FindElements(By.XPath("//li[@class='element-wrap page']/span/span"));
            //    int max_page = Convert.ToInt32(pages[pages.Count - 1].Text);
            //    for (int i = 0; i < 2; i++)
            //    {
            //        var price = driver.FindElements(By.XPath("//div[@class='p-c-price__price']/a/span"));
            //        var name = driver.FindElements(By.XPath("//div[@class='p-c-price__description']/a"));
            //        var img = driver.FindElements(By.XPath("//div[@class='p-c-price__image']/img"));
            //        var shop = driver.FindElements(By.XPath("//div/a[@class='cpc-link p-c-price__shop text-body-s-book']/span"));
            //        var link_item = driver.FindElements(By.XPath("//div/a[@class='cpc-link p-c-price__shop text-body-s-book']"));
            //        for (int j = 0; j < 10; j++)
            //        {
            //            if (!item_info.ContainsKey(shop[j].Text))
            //            {
            //                List<string> product = new List<string>
            //                {
            //                    price[j].Text,
            //                    name[j].Text,
            //                    img[j].GetAttribute("src"),
            //                    link_item[j].GetAttribute("href")
            //                };

            //                item_info.Add(shop[j].Text, product);

            //            }
            //        }
            //        Console.WriteLine(i);


            //        next_page.Click();
            //    }

            //catch (Exception)
            //{
            //    var price = driver.FindElements(By.XPath("//div[@class='p-c-price__price']/a/span"));
            //    var name = driver.FindElements(By.XPath("//div[@class='p-c-price__description']/a"));
            //    var shop = driver.FindElements(By.XPath("//div/a[@class='cpc-link p-c-price__shop text-body-s-book']/span"));
            //    var link_item = driver.FindElements(By.XPath("//div/a[@class='cpc-link p-c-price__shop text-body-s-book']"));
            //    var img = driver.FindElements(By.XPath("//div[@class='p-c-price__image']/img"));
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (!item_info.ContainsKey(shop[j].Text))
            //        {
            //            List<string> product = new List<string>
            //                {
            //                    price[j].Text,
            //                    name[j].Text,
            //                    img[j].GetAttribute("src"),
            //                    link_item[j].GetAttribute("href")
            //                };

            //            item_info.Add(shop[j].Text, product);

            //        }
            //    }
            //}
            //foreach (string item in item_info.Keys)
            //{
            //    textBox1.Text += $"{item}" + Environment.NewLine;
            //}
            #endregion
        }

        private Dictionary<string, string> get_data(string url, string search, Dictionary<string,string> xpath) 
        {
            driver.Navigate().GoToUrl($"{url}{search}");
            Thread.Sleep(1000);
            var wer = driver.PageSource;
            var name_item = driver.FindElement(By.XPath(xpath["name"]));
            var price_item = driver.FindElement(By.XPath(xpath["price"]));
            //var img_item = driver.FindElement(By.XPath(xpath["img"]));
            var link_item = driver.FindElement(By.XPath(xpath["link"]));
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                ["name"] = name_item.Text,
                ["price"] = wer,
                ////["img"] = img_item.GetAttribute("src"),
                //["link"] = link_item.GetAttribute("href")

            };


            return result;




        }
    }
}
