using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnKhoaIT2.Common
{
    public class RemmemberMe
    {
        public static HttpCookie CreateCookie(string txt,string input)
        {
            HttpCookie ck = new HttpCookie(txt);
            ck.Value = input;
            ck.Expires = DateTime.Now.AddDays(1);
            return ck;
        }
    }
}