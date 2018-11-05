using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace APIautomationtest
{
    public static class APImethods
    {
        public static RestClient client;
        public static RestRequest request;
        public static string baseurl ="https://postman-echo.com/";

        public static RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseurl,endpoint);
            return client = new RestClient(url);

        }
        public static RestRequest CreateRequest()          
        {

            request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            return request;
            
         }

        public static RestRequest CreateRequest(string userid)
        {
            var resource = userid;
            request = new RestRequest(resource,Method.GET);
            request.AddHeader("Accept", "application/json");
            return request;

        }


        public static IRestResponse GetResponse()
        {
            return client.Execute(request);
          

        }

       
    }
}
