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
        Dictionary<string, string> xpath_eld;
        Dictionary<string, string> xpath_mv;
        Dictionary<string, string> xpath_dns;
        Dictionary<string, string> xpath_el;
        Dictionary<string, string> xpath_ya;
        Dictionary<string, string> xpath_sb;

        ChromeOptions options = new ChromeOptions();
        ChromeDriver driver;
        Dictionary<string, string> shop_url;
        public KvantuMarket()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            shop_url = new Dictionary<string, string>();
            xpath_eld = new Dictionary<string, string>();
            xpath_mv = new Dictionary<string, string>();
            xpath_dns = new Dictionary<string, string>();
            xpath_el = new Dictionary<string, string>();
            xpath_ya = new Dictionary<string, string>();
            xpath_sb = new Dictionary<string, string>();

            #region options


            options.AddArguments("--headless");
            //options.AddArguments("--disable-gpu");            
            options.AddArguments("--disable-javascript");
            options.AddArguments("--disable-plugins");
            options.AddArguments("--disable-java");
            //options.AddArguments("--blink-settings");
            options.AddArguments("user-agent='Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.84 Safari/537.36'");
            options.AddArguments("--no-sandbox");
            //options.AddArguments("--ignore-certificate-errors");
            //options.AddArguments("--disable-automation");
            //options.AddArguments("--disable-blink-features=AutomationControlled");
            #endregion

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://www.eldorado.ru/search/catalog.php?q=");
            
            shop_url.Add("Эльдорадо", "https://www.eldorado.ru/search/catalog.php?q=");
            //shop_url.Add("Днс", "https://www.dns-shop.ru/search/?q=");
            //shop_url.Add("Мвидео", "https://www.mvideo.ru/product-list-page?q=");
            shop_url.Add("Элекс", "https://elex.ru/search/?q=");
            shop_url.Add("Яндекс", "https://market.yandex.ru/search?cvredirect=2&text=");
            shop_url.Add("Сбер", "https://sbermegamarket.ru/catalog/?q=");


            #region xpath
            xpath_eld.Add("name", "//div/a[@data-dy='title']");
            xpath_eld.Add("price", "//div/span[@data-pc='offer_price']");
            xpath_eld.Add("img", "//div[@data-dy='productsList']/a/img");
            xpath_eld.Add("link", "//li/div[@data-dy='productsList']/a");

            xpath_mv.Add("price", "//span[@class='price__main-value']");
            xpath_mv.Add("name", "//div[@class='product-title product-title--grid']/a");
            xpath_mv.Add("img", "//img[@class='product-picture__img product-picture__img--grid']");
            xpath_mv.Add("link", "//div[@class='product-title product-title--grid']/a");

            xpath_dns.Add("price", "//div[@class='product-buy__price']");
            xpath_dns.Add("name", "//div[@data-id='product']/a/span");
            xpath_dns.Add("img", "//div[@data-id='product']/div/a/picture/img");
            xpath_dns.Add("link", "//a[@class='catalog-product__name ui-link ui-link_black']");

            xpath_el.Add("price", "//span[@class='product__new']");
            xpath_el.Add("name", "//a[@class='product__name']");
            xpath_el.Add("img", "//img[@itemprop='image']");
            xpath_el.Add("link", "//div[@class='product__info']/a");

            xpath_ya.Add("price", "//div[@data-zone-name='price']/div/a/div/span/span");
            xpath_ya.Add("name", "//h3[@data-zone-name='title']");
            xpath_ya.Add("img", "//div[@class='_2zfPd']/a/img");
            xpath_ya.Add("link", "//div[@class='_2zfPd']/a");

            xpath_sb.Add("price", "//div[@itemprop='offers']/span");
            xpath_sb.Add("name", "//div[@itemprop='name']/a");
            xpath_sb.Add("img", "//div[@class='item-image item-image_changeable']/a/img");
            xpath_sb.Add("link", "//div[@itemprop='name']/a");
            #endregion
        }

        private void start_search_Click(object sender, EventArgs e)
        {           
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> eld_result = new Dictionary<string, string>();
            Dictionary<string, string> sb_result = new Dictionary<string, string>();
            Dictionary<string, string> mv_result = new Dictionary<string, string>();
            string search = search_string.Text;
            eld_result = get_data(shop_url["Эльдорадо"], search, xpath_eld);
            result.Add("Эльдорадо", eld_result);
            sb_result = get_data(shop_url["Сбер"], search, xpath_sb);
            result.Add("Сбер", sb_result);

            best_info.Text = $"{result["Сбер"]["name"]}\n\nЦена: {result["Сбер"]["price"]}";
            best_link.Text = $"{result["Сбер"]["link"]}";
            inf_box1.Text = $"{result["Эльдорадо"]["name"]}\n\nЦена: {result["Эльдорадо"]["price"]}";

            title.Text = $"По вашему запросу {search} было найдено";
            best_price.Text = "Лучшая цена";

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
            var name_item = driver.FindElement(By.XPath(xpath["name"]));
            var price_item = driver.FindElement(By.XPath(xpath["price"]));
            //var img_item = driver.FindElement(By.XPath(xpath["img"]));
            var link_item = driver.FindElement(By.XPath(xpath["link"]));
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                ["name"] = name_item.Text,
                ["price"] = price_item.Text,
                ////["img"] = img_item.GetAttribute("src"),
                ["link"] = link_item.GetAttribute("href")

            };
            return result;




        }

        private void best_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(best_link.Text);
        }
    }
}
