using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine(kanyeQuote);  



        }
    }
}
