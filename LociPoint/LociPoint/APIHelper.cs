using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LociPoint
{
   public static class APIHelper
    {
        public static string response;
        public static readonly HttpClient client = new HttpClient();
        public static async Task requestAsync(int amount, string nat)
        {

            string url = "https://randomuser.me/api/?results=" + amount.ToString() + "&nat=" + nat;

            var responseString = await client.GetStringAsync(url);
            response = responseString;
           
        }
       
    }
}
