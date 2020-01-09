using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfiguringApps.Infrastructure;

namespace ConfiguringApps.Controllers
{
    public class HomeController:Controller
    {
        private UptimeService uptime= new UptimeService();
        public ViewResult Index() =>
            View(new Dictionary<string, string> 
            { 
                ["Message"] = "This is controller Home",
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
    }
}
