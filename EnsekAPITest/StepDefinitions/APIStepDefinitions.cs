using Newtonsoft.Json;
using EnsekAPITest.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;

namespace EnsekAPITest.StepDefinitions
{
    [Binding]
    public class APIStepDefinitions
    {
        HttpClient httpClient;
        HttpResponseMessage response;
        string responsebody;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        public APIStepDefinitions(ISpecFlowOutputHelper _specFlowOutputHelper)
        {
            httpClient = new HttpClient();
            this._specFlowOutputHelper = _specFlowOutputHelper;
        }

        [Given(@"I have logged in to obtain auth token")]
        public async Task GivenIHaveLoggedInToObtainAuthToken()
        {
            Login loginDetails = new Login()
            {
                username = "test",
                password = "testing"
            };

            string data = JsonConvert.SerializeObject(loginDetails);
            var contentdata = new StringContent(data);

            response = await httpClient.PostAsync("https://qacandidatetest.ensek.io/ENSEK/login", contentdata);

            responsebody = await response.Content.ReadAsStringAsync();
            _specFlowOutputHelper.WriteLine("Post response is " + responsebody);
            // create a var for auth token

        }

        [Then(@"I reset all test data")]
        private static void ThenIResetAllTestData1()
        {
            //Using the auth when logged in POST the reset

        }

        [Given(@"I send a PUT request for the following energy and units required")]
        public void GivenISendAPUTRequestForTheFollowingEnergyAndUnitsRequired(Table table)
        {
            //for each type send a request
            //store each order number into a table 
        }

        [Then(@"using the order ID verify the orders have been added")]
        public void ThenUsingTheOrderIDVerifyTheOrdersHaveBeenAdded()
        {
            //Using the order ID's check each order has been placed
        }

        [Given(@"I Get the number of current")]
        public void GivenIGetTheNumberOfCurrent()
        {
            //GET request for order
            //Count the number of orders
        }

        [When(@"I place an order")]
        public async Task WhenIPlaceAnOrderAsync()
        {
            {
                BuyEnergy buyEnergy = new BuyEnergy()
                {
                    energy_id = 3,
                    quantity = 20
                };

                string data = JsonConvert.SerializeObject(buyEnergy);
                var contentdata = new StringContent(data);

                response = await httpClient.PutAsync("https://qacandidatetest.ensek.io/ENSEK/login", contentdata);

                responsebody = await response.Content.ReadAsStringAsync();
                _specFlowOutputHelper.WriteLine("Post response is " + responsebody);

            }
        }

        [Then(@"The current number of order should have increased")]
        public void ThenTheCurrentNumberOfOrderShouldHaveIncreased()
        {
            //Recheck the order number count it should have increased by the number of orders just placed
        }

    }

}
