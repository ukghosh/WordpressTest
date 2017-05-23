using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Wordpress.steps
{

    public class ProviderFactory
    {
        //private delegate IDriverProvider NewProvider();

        private const string DefaultBrowser = "ie";

        private static Dictionary<string, IDriverProvider> _providers = new Dictionary<string, IDriverProvider>()
        {
            {DefaultBrowser , new IEProvider()} ,
            {"chrome", new ChromeProvider()} ,
            { "ff",  new FirefoxProvider() },
            
        };

        public static IDriverProvider AppConfig()
        {
            var browser = BrowserInstance();
            if (!_providers.ContainsKey(browser))
            {
                throw new Exception($"Unknown Browser:{browser}");
            }
            return _providers[browser];
        }


        private static string BrowserInstance()
        {
            var dev = ConfigurationManager.AppSettings["DriverProvider"];
            return (dev ?? DefaultBrowser).ToLower();
        }
    }
}
