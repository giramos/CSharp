
using FundamentosCSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FundamentosCSharp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //string url = "https://jsonplaceholder.typicode.com/posts"; POST
            //string url = "https://jsonplaceholder.typicode.com/posts/99"; PUT
            string url = "https://jsonplaceholder.typicode.com/posts/99"; //DELETE
            var client = new HttpClient();

            Post post = new()
            {
                userId = 50,
                body = "Hola como estan",
                title = "titulo de saludo"
            };

            var data = JsonSerializer.Serialize<Post>(post);
            //HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            //POST
            //var httpResponse = await client.PostAsync(url, content);
            //PUT
            //var httpResponse = await client.PutAsync(url, content);
            //DELETE
            var httpResponse = await client.DeleteAsync(url);

            if (httpResponse.IsSuccessStatusCode)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();

                //var postResult = JsonSerializer.Deserialize<Post>(result);
            }
        }

    }
}
