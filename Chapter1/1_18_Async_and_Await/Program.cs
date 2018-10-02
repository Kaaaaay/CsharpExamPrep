using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _1_18_Async_and_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.millicrypto.co.za");
                return result;
            }
        }
    }
}
