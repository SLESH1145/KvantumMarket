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
using HtmlAgilityPack;
using System.Text.RegularExpressions;

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
        Dictionary<string, string> xpath_siti;
        Dictionary<string, string> xpath_ot;
        Dictionary<string, string> xpath_np;

        ChromeOptions options = new ChromeOptions();
        ChromeDriver driver;
        Dictionary<string, string> shop_url;
        Dictionary<string, Dictionary<string, string>> result;
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
            xpath_siti = new Dictionary<string, string>();
            xpath_ot = new Dictionary<string, string>();
            xpath_np = new Dictionary<string, string>();

            #region options


            options.AddArguments("--headless");
            options.AddArguments("--disable-gpu");            
            options.AddArguments("--disable-javascript");
            options.AddArguments("--disable-plugins");
            options.AddArguments("--disable-java");
            options.AddArguments("--blink-settings");
            options.AddArguments("user-agent='Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.84 Safari/537.36'");
            options.AddArguments("--no-sandbox");
            //options.AddArguments("--ignore-certificate-errors");
            //options.AddArguments("--disable-automation");
            options.AddArguments("--disable-blink-features=AutomationControlled");
            #endregion

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://www.eldorado.ru/search/catalog.php?q=");

            shop_url.Add("Эльдорадо", "https://www.eldorado.ru/search/catalog.php?q=");
            shop_url.Add("Днс", "https://www.dns-shop.ru/search/?q=");
            //Add("Мвидео", "https://www.mvideo.ru/product-list-page?q=");
            shop_url.Add("Элекс", "https://elex.ru/search/?q=");
            //shop_url.Add("Яндекс", "https://market.yandex.ru/search?cvredirect=2&text=");
            shop_url.Add("Сбер", "https://sbermegamarket.ru/catalog/?q=");
            shop_url.Add("Ситилинк", "https://www.citilink.ru/search/?text=");
            shop_url.Add("ОнлайнТрейд", "https://www.onlinetrade.ru/sitesearch.html?query=");
            shop_url.Add("NicePrice", "https://www.niceprice62.ru/?digiSearch=true&term=");


            #region xpath
            xpath_eld.Add("name", "//div/a[@data-dy='title']");
            xpath_eld.Add("price", "//div/span[@data-pc='offer_price']");
            xpath_eld.Add("img", "//div[@data-dy='productsList']/a/img");
            xpath_eld.Add("link", "//li/div[@data-dy='productsList']/a");

            //xpath_mv.Add("price", "//span[@class='price__main-value']");
            //xpath_mv.Add("name", "//div[@class='product-title product-title--grid']/a");
            //xpath_mv.Add("img", "//img[@class='product-picture__img product-picture__img--grid']");
            //xpath_mv.Add("link", "//div[@class='product-title product-title--grid']/a");

            //xpath_dns.Add("price", "//div[@class='product-buy__price']");
            //xpath_dns.Add("name", "//div[@data-id='product']/a/span");
            //xpath_dns.Add("img", "//div[@data-id='product']/div/a/picture/img");
            //xpath_dns.Add("link", "//a[@class='catalog-product__name ui-link ui-link_black']");

            xpath_el.Add("price", "//span[@class='product__new']");
            xpath_el.Add("name", "//a[@class='product__name']");
            xpath_el.Add("img", "//img[@itemprop='image']");
            xpath_el.Add("link", "//div[@class='product__info']/a");

            //xpath_ya.Add("price", "//div[@data-zone-name='price']/div/a/div/span/span");
            //xpath_ya.Add("name", "//h3[@data-zone-name='title']");
            //xpath_ya.Add("img", "//div[@class='_2zfPd']/a/img");
            //xpath_ya.Add("link", "//div[@class='_2zfPd']/a");

            xpath_sb.Add("price", "//div[@itemprop='offers']/span");
            xpath_sb.Add("name", "//div[@itemprop='name']/a");
            xpath_sb.Add("img", "//div[@class='item-image item-image_changeable']/a/img");
            xpath_sb.Add("link", "//div[@itemprop='name']/a");

            xpath_siti.Add("price", "//span[@class='ProductCardVerticalPrice__price-current_current-price js--ProductCardVerticalPrice__price-current_current-price ']");
            xpath_siti.Add("name", "//a[@class=' ProductCardVertical__name  Link js--Link Link_type_default']");
            xpath_siti.Add("img", "");
            xpath_siti.Add("link", "");

            xpath_ot.Add("price", "//span[@class='price regular']");
            xpath_ot.Add("name", "//a[@class='indexGoods__item__name']");
            xpath_ot.Add("img", "");
            xpath_ot.Add("link", "");

            #endregion
        }

        private void start_search_Click(object sender, EventArgs e)
        {           
            result = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> siti_result;
            Dictionary<string, string> el_result;
            Dictionary<string, string> ot_result;
            Dictionary<string, string> eld_result;
            Dictionary<string, string> sb_result;
            Dictionary<string, string> ya_result;
            Dictionary<string, string> dns_result;

            string search = search_string.Text;
            eld_result = get_data_selenium(shop_url["Эльдорадо"], search, xpath_eld);
            result.Add("Эльдорадо", eld_result);
            sb_result = get_data_selenium(shop_url["Сбер"], search, xpath_sb);
            result.Add("Сбер", sb_result);

            siti_result = get_data_request(shop_url["Ситилинк"], search, xpath_siti);
            result.Add("Ситилинк", siti_result);
            el_result = get_data_request(shop_url["Элекс"], search, xpath_el);
            result.Add("Элекс", el_result);
            ot_result = get_data_request(shop_url["ОнлайнТрейд"], search, xpath_ot);
            result.Add("ОнлайнТрейд", ot_result);
            //MessageBox.Show(best_shop(result));
            best_info.Text = $"{result["Сбер"]["name"]}\n\nЦена: {result["Сбер"]["price"]}";
            best_info.BackColor = Color.FromName("MenuBar");
            best_link.Text = $"{result["Сбер"]["link"]}";
            best_link.BackColor = Color.FromName("MenuBar");

            inf_box1.Text = $"{result["Эльдорадо"]["name"]}";
            price_1.Text = $"{result["Эльдорадо"]["price"]}";
            link_1.Text = $"{result["Эльдорадо"]["link"]}";
            price_1.BackColor = Color.FromName("MenuBar");
            inf_box1.BackColor = Color.FromName("MenuBar");
            link_1.BackColor = Color.FromName("MenuBar");

            name_2.Text = $"{result["Ситилинк"]["name"]}";
            price_2.Text = $"{result["Ситилинк"]["price"]}";
            link_2.Text = $"{result["Ситилинк"]["link"]}";
            price_2.BackColor = Color.FromName("MenuBar");
            name_2.BackColor = Color.FromName("MenuBar");
            link_2.BackColor = Color.FromName("MenuBar");

            name_3.Text = $"{result["ОнлайнТрейд"]["name"]}";
            price_3.Text = $"{result["ОнлайнТрейд"]["price"]}";
            link_3.Text = $"{result["ОнлайнТрейд"]["link"]}";
            price_3.BackColor = Color.FromName("MenuBar");
            name_3.BackColor = Color.FromName("MenuBar");
            link_3.BackColor = Color.FromName("MenuBar");

            name_4.Text = $"{result["Элекс"]["name"]}";
            price_4.Text = $"{result["Элекс"]["price"]}";
            link_4.Text = $"{result["Элекс"]["link"]}";
            price_4.BackColor = Color.FromName("MenuBar");
            name_4.BackColor = Color.FromName("MenuBar");
            link_4.BackColor = Color.FromName("MenuBar");

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

        private Dictionary<string, string> get_data_selenium(string url, string search, Dictionary<string,string> xpath) 
        {
            Dictionary<string, string> result = new Dictionary<string, string>()
            {
                ["name"] = null,
                ["price"] = null,
                ["link"] = null,
                ["img"] = null

            }; 
            try
            {
                driver.Navigate().GoToUrl($"{url}{search}");
                Thread.Sleep(1000);
                var name_item = driver.FindElement(By.XPath(xpath["name"]));
                result["name"] = name_item.Text.Trim();
                var price_item = driver.FindElement(By.XPath(xpath["price"]));
                result["price"] = price_item.Text.Trim();
                var img_item = driver.FindElement(By.XPath(xpath["img"]));
                result["img"] = img_item.GetAttribute("src").Trim();
                var link_item = driver.FindElement(By.XPath(xpath["link"]));  
                result["link"] = link_item.GetAttribute("href").Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }
        private Dictionary<string, string> get_data_request(string url, string search, Dictionary<string, string> xpath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc;
            Dictionary<string, string> result = new Dictionary<string, string>()
            {
                ["name"] = null,
                ["price"] = null,
                ["link"] = null,
                ["img"] = null


            };
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36";
            try
            {
                doc = web.Load($"{url}{search}", "GET");
                HtmlNode name = doc.DocumentNode.SelectSingleNode(xpath["name"]);
                result["name"] = $"{name.InnerText.Trim()}";
                HtmlNode price = doc.DocumentNode.SelectSingleNode(xpath["price"]);
                result["price"] = $"{price.InnerText.Trim()}";
                HtmlNode link = doc.DocumentNode.SelectSingleNode(xpath["link"]);
                result["link"] = $"{link.Attributes["href"].Value.Trim()}";
                HtmlNode img = doc.DocumentNode.SelectSingleNode(xpath["img"]); 
                result["img"] = $"{link.Attributes["src"].Value.Trim()}";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        private string best_shop(Dictionary<string, Dictionary<string, string>> result)
        {
            int min = 100000;
            string name_best_shop = "";
            
            foreach (KeyValuePair<string, Dictionary<string, string>> pair in result)
            {

                string price = Regex.Replace(pair.Value["price"], @"[^0-9]", string.Empty, RegexOptions.ECMAScript);
                pair.Value["price"] = price.Trim();
                if (min > Convert.ToInt32(pair.Value["price"]))
                {
                    min = Convert.ToInt32(pair.Value["price"]);
                    name_best_shop = pair.Key;
                }
                
            }
            return name_best_shop;
        
        }
        /*TO DO
         1. Link in requests
         2. Best price
         3. New market
         */


        private void best_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(best_link.Text);
        }

        private void link_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_1.Text);
        }

        private void link_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_2.Text);
        }

        private void link_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_3.Text);
        }

        private void link_4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_4.Text);
        }

        private void link_5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link_5.Text);
        }
    }
}
