using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Furloader.Sites
{
    public class FurAffinity
    {
        private const string FABase = "https://www.furaffinity.net/";
        private const string FALoginPage = "https://www.furaffinity.net/login/";

        private WebHandler webHandler = new WebHandler();

        public string getCookies() {
            Uri fa = new Uri(FABase);
            string cookies = webHandler.getCookies(fa);
            return cookies;
        }

        public Image GetCaptcha()
        {
            string html = webHandler.getPage(FALoginPage);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            string captchaLink = doc.GetElementbyId("captcha_img").Attributes["src"].Value;

            return webHandler.getImage(FABase + captchaLink);
        }

        public string login(string username, string password, string captcha)
        {
            string postData = string.Format("action=login&name={0}&pass={1}&g-recaptcha-response=&use_old_captcha=1&captcha={2}&login={3}",
                username,
                password,
                captcha,
                "Login to%C2%A0FurAffinity");

            webHandler.getPage(FALoginPage + "?ref=https://furaffinity.net/", postData);

            if (isLoggedIn())
            {
                Uri uri = new Uri(FABase);
                string cookie = webHandler.getCookies(uri);
                return cookie;
            }
            return null;
        }

        private bool isLoggedIn()
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            string web = webHandler.getPage(FABase);
            doc.LoadHtml(web);
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//a[@href='/submit/']");

            if (node == null)
            {
                return false;
            }

            string cookies = getCookies();

            return true;
        }
    }
}
