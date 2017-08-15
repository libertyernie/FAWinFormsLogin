using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Furloader.Sites;

namespace Furloader
{
    enum SITES { FurAffinity }

    public class WorkSheduler
    {
        private FurAffinity FA = new FurAffinity();
        
        public LoginData GetLoginData(string siteString)
        {
            Website site = getSiteFromString(siteString);
            if(site != null)
            {
                return site.GetLoginData();
            }
            return new LoginData();
        }

        public string loginSite(string siteString, string username, string password, string captcha = null)
        {
            Website site = getSiteFromString(siteString);

            if (site != null)
            {
                return site.login(username, password, captcha);
            }
            return null;
        }

        public bool checkLogin(string siteString, string cookies)
        {
            Website site = getSiteFromString(siteString);
            if (site != null)
            {
                return site.checkLogin(cookies);
            }
            return false;
        }

        private Website getSiteFromString(string siteString)
        {
            Website site;
            switch (siteString.ToLower())
            {
                case "fa":
                    site = FA;
                    break;
                case "furaffinity":
                    site = FA;
                    break;
                default:
                    site = null;
                    break;
            }
            return site;
        }

    }
}
