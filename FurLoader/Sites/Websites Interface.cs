using System;
using System.Collections.Generic;
using System.Drawing;

namespace Furloader.Sites
{

    public struct LoginData
    {
        public Image Captcha;
    }

    public class Website
    {
        public virtual string login(string username, string password, string captcha = null) { return null; }
        public virtual LoginData GetLoginData() { return new LoginData(); }
        public virtual bool checkLogin(string cookies) { return false; }
        public virtual string getCookies() { return null; }
        public virtual string Name { get; }
    }
}
