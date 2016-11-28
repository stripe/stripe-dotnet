using System.Linq;
using System.Net.Http;
using Machine.Specifications;
using Newtonsoft.Json.Linq;
using Stripe.Infrastructure;

namespace Stripe.Tests
{
    public class when_building_the_client
    {
        private static Client client;
        private static HttpRequestMessage request;

        Establish context = () =>
        {
            request = new HttpRequestMessage();
            client = new Client(request);
        };

        Because of = () =>
        {
            client.ApplyClientData();
            client.ApplyUserAgent();
        };

        It should_have_the_user_agent = () =>
            request.Headers.UserAgent.ToString().ShouldStartWith("Stripe/v1 .NetBindings/");

        It should_have_the_client_user_agent = () =>
            request.Headers.GetValues("X-Stripe-Client-User-Agent").ShouldNotBeNull();

        It should_have_the_client_user_agent_cast_to_json = () =>
        {
            var clientData = JToken.Parse(request.Headers.GetValues("X-Stripe-Client-User-Agent").FirstOrDefault());
        };

        It should_have_the_net45_for_uname = () =>
        {
            var clientData = JToken.Parse(request.Headers.GetValues("X-Stripe-Client-User-Agent").FirstOrDefault());
            clientData.SelectToken("uname").ToString().ShouldContain("net45.");
        };
    }
}