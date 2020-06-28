using System;
using System.Threading.Tasks;
using GeniusAPIWrapper;
using GeniusAPIWrapper.JsonData.Search;
using GeniusAPIWrapper.Requests;

namespace WrapperTest
{
    internal class Program
    {
        internal static async Task Main(string[] args)
        {
            var handler = new APIHandler("3VESSI-JxeTMqgIxUlNpmU516qvCEzSKhHdbxi9966Jg1VPqOc_S5GQ8oljqYpkI");
            
            var response1 = await APIHandler.SendRequest(ApiRequestType.Search, "smrtDeath - everything") as SearchResponse;
            
            var response2 = await APIHandler.SendRequest(ApiRequestType.Search, "Mili-Nine Point Eight") as SearchResponse;
            
            var response3 = await APIHandler.SendRequest(ApiRequestType.Search, "Smrtdeath - Gave U My Heart Said Dont Fuck Around With It") as SearchResponse;
            
            var response4 = await APIHandler.SendRequest(ApiRequestType.Search, "Smrtdeath - No One Looks at Me Like the Way That You Used 2") as SearchResponse;
            
            var response5 = await APIHandler.SendRequest(ApiRequestType.Search, "smrtdeath - yung disaster") as SearchResponse;
            
            Console.WriteLine(response1.Lyrics);
            Console.WriteLine(response2.Lyrics);
            Console.WriteLine(response3.Lyrics);
            Console.WriteLine(response4.Lyrics);
            Console.WriteLine(response5.Lyrics);
        }
    }
}