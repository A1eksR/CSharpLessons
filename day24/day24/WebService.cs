using System;
namespace day24
{
	public class WebService
	{
        public void GetPosts(HttpClient client)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/posts");
            requestMessage.Headers.Add("Accept", "application/json");

            
            var response = client.Send(requestMessage);

            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }
        public void GetComment(HttpClient client)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/comments");
            requestMessage.Headers.Add("Accept", "application/json");

            var response = client.Send(requestMessage);

            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            
        }
    }
}

