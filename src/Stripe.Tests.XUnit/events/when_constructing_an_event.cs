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
        private string StripeSignature => "t=1493329224,v1=09b8e30b483570b410390cdac6327c036937e84a6316008a0143db833ac21a09,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
        private string StripeJson         { get; set; }
        private string StripeSecret =>    "whsec_H68eTX02a4bCbiQOOoSAsIytOvuWZrQC";

        private StripeEvent ConstructedEvent { get; set; }

        public when_constructing_an_event()
        {
            StripeJson = new StreamReader(
                typeof(when_constructing_an_event).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit.events.event.json"),
                Encoding.UTF8
            ).ReadToEnd();

            ConstructedEvent = StripeEventUtility.ConstructEvent(StripeJson, StripeSignature, StripeSecret);
        }

        public StripeAccount Account { get; set; }

        [Fact]
        public void it_should_validate_with_right_secret()
        {
            ConstructedEvent.Should().NotBeNull();
        }
    }
}
