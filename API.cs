using System;
using System.Net.Http;

using RestSharp;
using RestSharp.Authenticators;

namespace github
{
    class API
    {
        static void Main()
        {
            string api_url = "https://api.github.com";
            string command = "/users/Eiriksmal";

            var client = new RestClient();
            client.BaseUrl = new Uri(api_url);

            var request = new RestRequest(Method.GET);
            request.Resource = command;
            request.AddHeader("Accept", "application/vnd.github.v3+json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            // request.AddHeader("cache-control", "max-age=0, private, must-revalidate");
            // request.AddParameter("application/json", "{}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string contents = response.Content;

            Console.WriteLine(contents);
            return;
        }
    }
}
