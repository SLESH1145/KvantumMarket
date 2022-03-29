using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace Kvantum_Market
{
    class PServer
    {
        private static ProxyServer proxyServer;

        public PServer()
        {
            proxyServer = new ProxyServer();
            proxyServer.BeforeResponse += OnResponse;
            var explicitEndPoint = new ExplicitProxyEndPoint(IPAddress.Loopback, 8000, true);
            explicitEndPoint.BeforeTunnelConnectRequest += OnBeforeTunnelConnectRequest;
            proxyServer.AddEndPoint(explicitEndPoint);
            proxyServer.Start();

        }
        private async Task OnBeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs e)
        {
            if (!e.HttpClient.Request.Url.Contains("www.price.ru"))
            {
                e.DecryptSsl = false;
            }
        }
        public async Task OnResponse(object sender, SessionEventArgs e)
        {
            if (e.HttpClient.Response.StatusCode == 200 && (e.HttpClient.Request.Method == "GET" || e.HttpClient.Request.Method == "POST"))
            {
                string url = e.HttpClient.Request.Url;
                if (url.Contains("price.ru/v3/models/4336912/offers?region_id=100"))
                {
                    Console.WriteLine(await e.GetResponseBodyAsString());
                }
            }
        }
    }
}
