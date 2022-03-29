﻿using HtmlAgilityPack;
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

namespace Kvantum_Market
{
    public partial class KvantuMarket : Form
    {
        Dictionary<string, string> item_info_eld;
        Dictionary<string, string> item_info_mv;
        Dictionary<string, string> item_info_dns;

        ChromeOptions options = new ChromeOptions();
        ChromeDriver driver;
        Dictionary<string, string> shop_url;
        //li[@class="element-wrap page"]/span/span
        //div[@class="p-c-price__description"]/a ----------- name
        //div[@class="p-c-price__price"]/a ------------------ price
        //div[@class="p-c-price__image"]/img    .GetAttribute("src") https://price.ru/search/?query=%D0%BD%D0%B0%D1%83%D1%88%D0%BD%D0%B8%D0%BA%D0%B8%20airpods%20pro
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
            options.AddArguments("--headless");
            options.AddArguments("--disable-gpu");
            options.AddArguments("--remote-debugging-port=9222");
            //options.AddArguments("--enable-javascript");
            options.AddArguments("user-agent='Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.84 Safari/537.36'");
            options.AddArguments("--no-sandbox");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--allow-insecure-localhost");
            options.AddArguments("--disable-blink-features=AutomationControlled");
            driver = new ChromeDriver(@"D:\C#\KvantumMarket\KvantumMarket\Kvantum Market", options);
            shop_url.Add("Эльдорадо", "https://www.eldorado.ru/search/catalog.php?q=");
            shop_url.Add("Днс", "https://www.dns-shop.ru/search/?q=");
            shop_url.Add("Мвидео", "https://www.mvideo.ru/product-list-page?q=");

            item_info_eld.Add("name", "//div/a[@data-dy='title']");
            item_info_eld.Add("price", "//div/span[@data-pc='offer_price']");
            item_info_eld.Add("img", "//div[@data-dy='productsList']/a/img");
            item_info_eld.Add("link", "//li/div[@class='sG uG']/a");

            item_info_mv.Add("price", "//span[@class='price__main-value']");
            item_info_mv.Add("name", "//div[@class='product-title product-title--grid']/a");
            item_info_mv.Add("img", "//img[@class='product-picture__img product-picture__img--grid']");
            item_info_mv.Add("link", "//div[@class='product-title product-title--grid']/a");

            item_info_dns.Add("price", "//div[@class='product-buy__price']");
            item_info_dns.Add("name", "//div[@data-id='product']/a/span");
            item_info_dns.Add("img", "//div[@data-id='product']/div/a/picture/img");
            item_info_dns.Add("link", "//a[@class='catalog-product__name ui-link ui-link_black']");

        }

        private void start_search_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            string search = search_string.Text;
            result = get_data(shop_url["Эльдорадо"], search, item_info_eld);
            foreach (string item in result)
            {
                textBox1.Text += item + Environment.NewLine;
            }
            result.Clear();
            result = get_data(shop_url["Мвидео"], search, item_info_mv);
            foreach (string item in result)
            {
                textBox1.Text += item + Environment.NewLine;
            }
            result.Clear();
            //result = get_data(shop_url["Днс"], search, item_info_dns);
            //foreach (string item in result)
            //{
            //    textBox2.Text += item + Environment.NewLine;
            //}
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

        private List<string> get_data(string url, string search, Dictionary<string,string> xpath) 
        {
            driver.Navigate().GoToUrl($"{url}{search}");
            Thread.Sleep(3000);
            var name_item = driver.FindElement(By.XPath(xpath["name"]));
            var price_item = driver.FindElement(By.XPath(xpath["price"]));
            var img_item = driver.FindElement(By.XPath(xpath["img"]));
            var link_item = driver.FindElement(By.XPath(xpath["link"]));
            List<string> result = new List<string>
            {
                name_item.Text,
                price_item.Text,
                img_item.GetAttribute("src"),
                link_item.GetAttribute("href")

            };


            return result;
        }
    }
}