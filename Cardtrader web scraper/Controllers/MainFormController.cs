using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardtrader_web_scraper.Controllers
{
    public class MainFormController: Controller
    {
        // Constructor
        public MainFormController() 
        {
            // Constructor logic, if any
        }

        #region Retrieve HTML

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<string> CallUrl(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("myApp1");
            var response = await client.GetStringAsync(url);
            return response;
        }

        #endregion
    }
}
