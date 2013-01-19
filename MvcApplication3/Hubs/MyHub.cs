using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MvcApplication3.Hubs
{
    public class MyHub: Hub
    {
        public string GetCookie()
        {
            return Context.RequestCookies["x"].Value;
        }
    }
}