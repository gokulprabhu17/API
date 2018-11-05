using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APIautomationtest.Stepdefinition
{
    [Binding]
    public sealed class firsttest
    {
        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            APImethods.SetUrl(endpoint);
           
        }

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            APImethods.CreateRequest();
        }

        [Then(@"I get API response in json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            var apiresponse = APImethods.GetResponse();
            if (apiresponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("pass");
            }
        }
        [When(@"I call get method to get user information using user(.*)")]
        public void WhenICallGetMethodToGetUserInformationUsingUser(string userid)
        {
            APImethods.CreateRequest(userid);
        }

        [Then(@"I will get user information")]
        public void ThenIWillGetUserInformation()
        {
            APImethods.GetResponse();
        }


    }
}
