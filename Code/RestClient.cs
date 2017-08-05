using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace Code
{
    public class RestClient
    {
        IClient _client;
         public RestClient()
         {
            _client = new Client();
         }

         public async Task<HttpStatusCode> Execute(Request request)
         {
               var response = await _client.Get(request.URL);
               return response.StatusCode;
         } 
        
    }  
 
     public interface IClient
     {
        Task<HttpResponseMessage> Get(string url);

     }

    public class Client : IClient
    {
        public async Task<HttpResponseMessage> Get(string url)
        {
           using (HttpClient client = new HttpClient())
           { 
               client.BaseAddress = new Uri(url);
               return await client.GetAsync(url);
           }

        }
    }
}
