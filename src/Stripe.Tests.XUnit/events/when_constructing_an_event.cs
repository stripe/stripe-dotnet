using System.IO;
using System.Reflection;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_constructing_an_event
    {
        // this was sent in the header Stripe-Signature along with the body of event.json in a test webhook
        private static string StripeSignature => "t=1493329224,v1=dca14f723dfa3bf47a310c3d6c3aff8bdb2534263d051dd2613ece097b8bdea4,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
        private static string StripeJson { get; set; }
        private static string StripeSecret => "whsec_H68eTX02a4bCbiQOOoSAsIytOvuWZrQC";

        public StripeEvent ConstructedEvent { get; set; }

        public when_constructing_an_event()
        {
            StripeJson = new StreamReader(
                typeof(when_constructing_an_event).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit.events.event.json"),
                Encoding.UTF8
            ).ReadToEnd();

            // this throws an error because the tolerance was higher than allowed
            // ConstructedEvent = StripeEventUtility.ConstructEvent(StripeJson, StripeSignature, StripeSecret);

            // override the event utility from looking at utc now to 300 seconds in front of the timestamp in the header
            StripeEventUtility.EpochUtcNowOverride = 1493329524;

            ConstructedEvent = StripeEventUtility.ConstructEvent(StripeJson, StripeSignature, StripeSecret);

            // this throws an error that the signature doesn't match one in the headers
            //ConstructedEventBadJson = StripeEventUtility.ConstructEvent(StripeJson + "/n", StripeSignature, StripeSecret);
        }

        [Fact]
        public void it_should_validate_with_right_data()
        {
            ConstructedEvent.Should().NotBeNull();
            ConstructedEvent.Request.Id.Should().Be("req_FAKE");
            ConstructedEvent.Request.IdempotencyKey.Should().Be("placeholder");
            ConstructedEvent.Account.Should().Be("acct_CONNECT");
        }
    }
}
