using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Furloader.Sites
{
    public class FurAffinity : Website
    {
        public override string Name { get { return "furaffinity"; } }

        private const string FABase = "https://www.furaffinity.net/";
        private const string FALoginPage = "https://www.furaffinity.net/login/";
        private const string FACaptcha = "https://furaffinity.net/captcha.jpg";

        private int pos = 0;

        private WebHandler webHandler = new WebHandler();

        public override string getCookies() {
            Uri fa = new Uri(FABase);
            string cookies = webHandler.getCookies(fa);
            return cookies;
        }

        public override bool checkLogin(string cookies)
        {
            if (cookies == "")
            {
                return false;
            }


            webHandler.setCookies(cookies);

            return isLoggedIn();
        }

        public override LoginData GetLoginData()
        {
            string html = webHandler.getPage(FALoginPage);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            string captchaLink = doc.GetElementbyId("captcha_img").Attributes["src"].Value;

            return new LoginData { Captcha = webHandler.getImage(FABase + captchaLink) };
        }

        public override string login(string username, string password, string captcha)
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

        private string sourceFromId(string pageSource)
        {
            return string.Format("{0}view/{1}/", FABase, pageSource.Remove(0, 3));
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
