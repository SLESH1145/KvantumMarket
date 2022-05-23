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
using Kvantum_Market.Properties;

namespace KvantumMarket
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
        Dictionary<string, string> xpath_mks;
        Dictionary<string, string> xpath_pr;
        Dictionary<string, string> xpath_sv;
        int i = 1;

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
            progressBar1.BackColor = Color.FromName("HighlightText");
            xpath_eld = new Dictionary<string, string>();
            xpath_mv = new Dictionary<string, string>();
            xpath_dns = new Dictionary<string, string>();
            xpath_el = new Dictionary<string, string>();
            xpath_ya = new Dictionary<string, string>();
            xpath_sb = new Dictionary<string, string>();
            xpath_siti = new Dictionary<string, string>();
            xpath_ot = new Dictionary<string, string>();
            xpath_mks = new Dictionary<string, string>();
            xpath_pr = new Dictionary<string, string>();
            xpath_sv = new Dictionary<string, string>();


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
            options.AddArguments("--disable-automation");
            options.AddArguments("--disable-blink-features=AutomationControlled");
            #endregion


            //driver.Navigate().GoToUrl("https://www.eldorado.ru/search/catalog.php?q=");


            shop_url.Add("Eldorado", "https://www.eldorado.ru/search/catalog.php?q=");
            //shop_url.Add("Днс", "https://www.dns-shop.ru/search/?q=");
            shop_url.Add("Elex", "https://elex.ru/search/?q=");
            //shop_url.Add("Яндекс", "https://market.yandex.ru/search?cvredirect=2&text=");
            shop_url.Add("Sber", "https://sbermegamarket.ru/catalog/?q=");
            shop_url.Add("Sitilink", "https://www.citilink.ru/search/?text=");
            //shop_url.Add("ОнлайнТрейд", "https://www.onlinetrade.ru/sitesearch.html?query=");
            shop_url.Add("MKS", "https://mks62.ru/index.php?route=product/search&search=");
            //shop_url.Add("MV", "https://www.mvideo.ru/product-list-page?q=");
            //shop_url.Add("Price", "https://ryazan.price.ru/search/?query=");
            shop_url.Add("Svyaznoy", "https://www.svyaznoy.ru/search?q=");


            #region xpath
            xpath_eld.Add("name", "//div/a[@data-dy='title']");
            xpath_eld.Add("price", "//div/span[@data-pc='offer_price']");
            xpath_eld.Add("img", "//div[@data-dy='productsList']/a/img");
            xpath_eld.Add("link", "//li/div[@data-dy='productsList']/a");
            xpath_eld.Add("old", "");

            //xpath_dns.Add("price", "//div[@class='product-buy__price']");
            //xpath_dns.Add("name", "//div[@data-id='product']/a/span");
            //xpath_dns.Add("img", "//div[@data-id='product']/div/a/picture/img");
            //xpath_dns.Add("link", "//a[@class='catalog-product__name ui-link ui-link_black']");

            xpath_el.Add("price", "//span[@class='product__new']");
            xpath_el.Add("name", "//a[@class='product__name']");
            xpath_el.Add("img", "//img[@itemprop='image']");
            xpath_el.Add("link", "//div[@class='product__info']/a");
            xpath_el.Add("old", "//span[@class='product__old']");

            //xpath_ya.Add("price", "//div[@data-zone-name='price']/div/a/div/span/span");
            //xpath_ya.Add("name", "//h3[@data-zone-name='title']");
            //xpath_ya.Add("img", "//div[@class='_2zfPd']/a/img");
            //xpath_ya.Add("link", "//div[@class='_2zfPd']/a");

            xpath_sb.Add("price", "//div[@itemprop='offers']/span");
            xpath_sb.Add("name", "//div[@itemprop='name']/a");
            xpath_sb.Add("img", "//div[@class='item-image item-image_changeable']/a/img");
            xpath_sb.Add("link", "//div[@itemprop='name']/a");
            xpath_sb.Add("old", "//span[@class='item-old-price__price item-old-price__price_spaced']");

            xpath_siti.Add("price", "//div[@class='ProductCardVerticalLayout__wrapper-cart']/div/div/div/div/div/span/span[@class='ProductCardVerticalPrice__price-current_current-price js--ProductCardVerticalPrice__price-current_current-price ']");
            xpath_siti.Add("name", "//a[@class=' ProductCardVertical__name  Link js--Link Link_type_default']");
            xpath_siti.Add("img", "//img[@class='ProductCardHorizontal__image Image']");
            xpath_siti.Add("link", "//a[@class=' ProductCardVertical__link link_gtm-js  Link js--Link Link_type_default']");
            xpath_siti.Add("old", "//span[@class='_current-price js--_current-price ']");

            //xpath_ot.Add("price", "//span[@class='price regular']");
            //xpath_ot.Add("name", "//a[@class='indexGoods__item__name']");
            //xpath_ot.Add("img", "");
            //xpath_ot.Add("link", "//a[@class='indexGoods__item__name']");

            xpath_mks.Add("price", "//p[@class='price']");
            xpath_mks.Add("name", "//div[@class='caption']/h4/a");
            xpath_mks.Add("img", "//img[@class='img-responsive']");
            xpath_mks.Add("link", "//div[@class='caption']/h4/a");
            xpath_mks.Add("old", "");

            //xpath_mv.Add("price", "//span[@class='price__main-value']");
            //xpath_mv.Add("name", "//a[@class='product-title__text product-title--clamp']");
            //xpath_mv.Add("img", "");
            //xpath_mv.Add("link", "//a[@class='product-title__text product-title--clamp']");

            //xpath_pr.Add("price", "//span[@class='text-subtitle-price-bold main-price']");
            //xpath_pr.Add("name", "//div[@class='p-c-price__description']/a");
            //xpath_pr.Add("img", "");
            //xpath_pr.Add("link", "//div/a[@class='cpc-link p-c-price__shop text-body-s-book']/span");

            xpath_sv.Add("price", "//div[@class='b-product-block__price-block  ']/span");
            xpath_sv.Add("name", "//span[@itemprop='name']");
            xpath_sv.Add("img", "//img[@itemprop='image']");
            xpath_sv.Add("link", "//a[@class='b-product-block__main-link']");
            xpath_sv.Add("old", "//div[@class='b-product-block__price-block  ']/s[@class='b-product-block__price-old']");

            #endregion
        }

        private void start_search_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, options);

            result = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> siti_result;
            Dictionary<string, string> el_result;
            Dictionary<string, string> ot_result;
            Dictionary<string, string> eld_result;
            Dictionary<string, string> sb_result;
            Dictionary<string, string> ya_result;
            Dictionary<string, string> dns_result;
            Dictionary<string, string> mks_result;
            Dictionary<string, string> mv_result;
            Dictionary<string, string> pr_result;
            Dictionary<string, string> sv_result;

            string search = search_string.Text;

            eld_result = get_data_selenium(shop_url["Eldorado"], search, xpath_eld);
            result.Add("Eldorado", eld_result);

            sb_result = get_data_selenium(shop_url["Sber"], search, xpath_sb);
            result.Add("Sber", sb_result);

            siti_result = get_data_request(shop_url["Sitilink"], search, xpath_siti);
            result.Add("Sitilink", siti_result);

            sv_result = get_data_selenium(shop_url["Svyaznoy"], search, xpath_sv);
            result.Add("Svyaznoy", sv_result);

            el_result = get_data_request(shop_url["Elex"], search, xpath_el);
            result.Add("Elex", el_result);

            mks_result = get_data_request(shop_url["MKS"], search, xpath_mks);
            result.Add("MKS", mks_result);

            driver.Quit();


            if (result["Sitilink"]["price"] != null)
            {
                result["Sitilink"]["price"] = result["Sitilink"]["price"].Replace(" ", "").Trim();
            }
            if (result["Elex"]["price"] != null)
            {
                result["Elex"]["price"] = result["Elex"]["price"].Replace("&nbsp;", "").Replace("руб.", "").Replace(" ", "");
            }
            if (result["Sber"]["price"] != null)
            {
                result["Sber"]["price"] = result["Sber"]["price"].Remove(result["Sber"]["price"].Length - 1).Replace(" ", "").Trim();
            }
            if (result["MKS"]["price"] != null)
            {
                result["MKS"]["price"] = result["MKS"]["price"].Remove(result["MKS"]["price"].Length - 1).Replace(" ", "").Replace("р", "").Trim();
            }
            if (result["Svyaznoy"]["price"] != null)
            {
                result["Svyaznoy"]["price"] = result["Svyaznoy"]["price"].Replace("руб.", "").Replace(" ", "").Trim();
            }
            if (result["Eldorado"]["price"] != null)
            {
                result["Eldorado"]["price"] = result["Eldorado"]["price"].Replace(" ", "").Trim();
            }



                
            

            result["Elex"]["link"] = $"https://elex.ru{result["Elex"]["link"]}";
            result["Sitilink"]["link"] = $"https://www.citilink.ru{result["Sitilink"]["link"]}";

            string best_shop_name = best_shop(result);


            best_info.Text = $"{result[best_shop_name]["name"]}\n\nЦена: {result[best_shop_name]["price"]} ₽";
            best_info.BackColor = Color.FromName("MenuBar");
            best_link.Text = $"{result[best_shop_name]["link"]}";
            if (result[best_shop_name]["img"] != null)
            {
                best_img.ImageLocation = result[best_shop_name]["img"];
            }
            best_link.BackColor = Color.FromName("MenuBar");
            result.Remove(best_shop_name);
            int i = 0;
            foreach (var name in result)
            {
                if (i == 0)
                {
                    inf_box1.Text = $"{result[name.Key]["name"]}";
                    price_1.Text = $"{result[name.Key]["price"]} ₽";
                    link_1.Text = $"{result[name.Key]["link"]}";
                    price_1.BackColor = Color.FromName("MenuBar");
                    inf_box1.BackColor = Color.FromName("MenuBar");
                    link_1.BackColor = Color.FromName("MenuBar");
                    if (name.Key == "Sber")
                    {
                        img_1.Image = Resources.Sber;
                    }
                    if (name.Key == "Svyaznoy")
                    {
                        img_1.Image = Resources.Svyznoy;
                    }
                    if (name.Key == "MKS")
                    {
                        img_1.Image = Resources.MKS;
                    }
                    if (name.Key == "Elex")
                    {
                        img_1.Image = Resources.Elex;
                    }
                    if (name.Key == "Sitilink")
                    {
                        img_1.Image = Resources.Sitilink;
                    }
                    if (name.Key == "Eldorado")
                    {
                        img_1.Image = Resources.Eldorado;
                    }
                    if (result[name.Key]["old"] != null)
                    {
                        price_1.ForeColor = Color.FromName("Red");
                    }
                }
                if (i == 1)
                {
                    name_2.Text = $"{result[name.Key]["name"]}";
                    price_2.Text = $"{result[name.Key]["price"]} ₽";
                    link_2.Text = $"{result[name.Key]["link"]}";
                    price_2.BackColor = Color.FromName("MenuBar");
                    name_2.BackColor = Color.FromName("MenuBar");
                    link_2.BackColor = Color.FromName("MenuBar");
                    if (name.Key == "Sber")
                    {
                        img_2.Image = Resources.Sber;
                    }
                    if (name.Key == "Svyaznoy")
                    {
                        img_2.Image = Resources.Svyznoy;
                    }
                    if (name.Key == "MKS")
                    {
                        img_2.Image = Resources.MKS;
                    }
                    if (name.Key == "Elex")
                    {
                        img_2.Image = Resources.Elex;
                    }
                    if (name.Key == "Sitilink")
                    {
                        img_2.Image = Resources.Sitilink;
                    }
                    if (name.Key == "Eldorado")
                    {
                        img_2.Image = Resources.Eldorado;
                    }
                    if (result[name.Key]["old"] != null)
                    {
                        price_2.ForeColor = Color.FromName("Red");
                    }
                }
                if (i == 2)
                {
                    name_3.Text = $"{result[name.Key]["name"]}";
                    price_3.Text = $"{result[name.Key]["price"]} ₽";
                    link_3.Text = $"{result[name.Key]["link"]}";
                    price_3.BackColor = Color.FromName("MenuBar");
                    name_3.BackColor = Color.FromName("MenuBar");
                    link_3.BackColor = Color.FromName("MenuBar");
                    if (name.Key == "Sber")
                    {
                        img_3.Image = Resources.Sber;
                    }
                    if (name.Key == "Svyaznoy")
                    {
                        img_3.Image = Resources.Svyznoy;
                    }
                    if (name.Key == "MKS")
                    {
                        img_3.Image = Resources.MKS;
                    }
                    if (name.Key == "Elex")
                    {
                        img_3.Image = Resources.Elex;
                    }
                    if (name.Key == "Sitilink")
                    {
                        img_3.Image = Resources.Sitilink;
                    }
                    if (name.Key == "Eldorado")
                    {
                        img_3.Image = Resources.Eldorado;
                    }
                    if (result[name.Key]["old"] != null)
                    {
                        price_3.ForeColor = Color.FromName("Red");
                    }
                }
                if (i == 3)
                {
                    name_4.Text = $"{result[name.Key]["name"]}";
                    price_4.Text = $"{result[name.Key]["price"]} ₽";
                    link_4.Text = $"{result[name.Key]["link"]}";
                    price_4.BackColor = Color.FromName("MenuBar");
                    name_4.BackColor = Color.FromName("MenuBar");
                    link_4.BackColor = Color.FromName("MenuBar");
                    if (name.Key == "Sber")
                    {
                        img_4.Image = Resources.Sber;
                    }
                    if (name.Key == "Svyaznoy")
                    {
                        img_4.Image = Resources.Svyznoy;
                    }
                    if (name.Key == "MKS")
                    {
                        img_4.Image = Resources.MKS;
                    }
                    if (name.Key == "Elex")
                    {
                        img_4.Image = Resources.Elex;
                    }
                    if (name.Key == "Sitilink")
                    {
                        img_4.Image = Resources.Sitilink;
                    }
                    if (name.Key == "Eldorado")
                    {
                        img_4.Image = Resources.Eldorado;
                    }
                    if (result[name.Key]["old"] != null)
                    {
                        price_4.ForeColor = Color.FromName("Red");
                    }
                }
                if (i == 4)
                {
                    name_5.Text = $"{result[name.Key]["name"]}";
                    price_5.Text = $"{result[name.Key]["price"]} ₽";
                    link_5.Text = $"{result[name.Key]["link"]}";
                    price_5.BackColor = Color.FromName("MenuBar");
                    name_5.BackColor = Color.FromName("MenuBar");
                    link_5.BackColor = Color.FromName("MenuBar");
                    if (name.Key == "Sber")
                    {
                        img_5.Image = Resources.Sber;
                    }
                    if (name.Key == "Svyaznoy")
                    {
                        img_5.Image = Resources.Svyznoy;
                    }
                    if (name.Key == "MKS")
                    {
                        img_5.Image = Resources.MKS;
                    }
                    if (name.Key == "Elex")
                    {
                        img_5.Image = Resources.Elex;
                    }
                    if (name.Key == "Sitilink")
                    {
                        img_5.Image = Resources.Sitilink;
                    }
                    if (name.Key == "Eldorado")
                    {
                        img_5.Image = Resources.Eldorado;
                    }
                    if (result[name.Key]["old"] != null)
                    {
                        price_5.ForeColor = Color.FromName("Red");
                    }
                }
                i++;
            }

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

        private Dictionary<string, string> get_data_selenium(string url, string search, Dictionary<string, string> xpath)
        {
            Dictionary<string, string> result = new Dictionary<string, string>()
            {
                ["name"] = null,
                ["price"] = null,
                ["link"] = null,
                ["img"] = null,
                ["old"] = null

            };
            try
            {
                driver.Navigate().GoToUrl($"{url}{search}");
                Thread.Sleep(1000);
                string cookie = driver.Manage().Cookies.ToString();
                var name_item = driver.FindElement(By.XPath(xpath["name"]));
                result["name"] = name_item.Text.Trim();
                var link_item = driver.FindElement(By.XPath(xpath["link"]));
                result["link"] = link_item.GetAttribute("href").Trim();
                var price_item = driver.FindElement(By.XPath(xpath["price"]));
                result["price"] = price_item.Text.Trim();
                var img_item = driver.FindElement(By.XPath(xpath["img"]));
                result["img"] = img_item.GetAttribute("src").Trim();
                try
                {
                    var old_item = driver.FindElement(By.XPath(xpath["old"]));
                    result["old"] = old_item.Text.Trim();
                }
                catch (Exception)
                {
                    result["old"] = null;
                }
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
                ["img"] = null,
                ["old"] = null


            };
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36";
            try
            {
                doc = web.Load($"{url}{search}", "GET");
                HtmlNode name = doc.DocumentNode.SelectSingleNode(xpath["name"]);
                result["name"] = $"{name.InnerText.Trim()}";
                HtmlNode link = doc.DocumentNode.SelectSingleNode(xpath["link"]);
                result["link"] = $"{link.Attributes["href"].Value.Trim()}";
                HtmlNode price = doc.DocumentNode.SelectSingleNode(xpath["price"]);
                result["price"] = $"{price.InnerText.Trim()}";
                HtmlNode img = doc.DocumentNode.SelectSingleNode(xpath["img"]);
                result["img"] = $"{img.Attributes["src"].Value.Trim()}";
                try
                {
                    HtmlNode old = doc.DocumentNode.SelectSingleNode(xpath["old"]);
                    result["old"] = $"{old.InnerText.Trim()}";
                }
                catch (Exception)
                {
                    result["old"] = null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
        private Dictionary<string, string> get_data_selenium_pr(string url, string search, Dictionary<string, string> xpath)
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
                Thread.Sleep(2000);
                var button = driver.FindElement(By.XPath("//a[@class='p-card__info-description pointer']"));
                driver.Navigate().GoToUrl($"{button.GetAttribute("href").Trim()}");
                Thread.Sleep(1000);
                var name_item = driver.FindElement(By.XPath(xpath["name"]));
                result["name"] = name_item.Text.Trim();
                var price_item = driver.FindElement(By.XPath(xpath["price"]));
                result["price"] = price_item.Text.Trim();
                var link_item = driver.FindElement(By.XPath(xpath["link"]));
                result["link"] = link_item.GetAttribute("href").Trim();
                var img_item = driver.FindElement(By.XPath(xpath["img"]));
                result["img"] = img_item.GetAttribute("src").Trim();
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
                if (pair.Value["price"] != null)
                {
                    if (min > Convert.ToInt32(pair.Value["price"]))
                    {
                        min = Convert.ToInt32(pair.Value["price"]);
                        name_best_shop = pair.Key;
                    }
                }


            }
            return name_best_shop;

        }



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
