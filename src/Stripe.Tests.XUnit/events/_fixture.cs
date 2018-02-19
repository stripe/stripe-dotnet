using System.IO;
using System.Reflection;
using System.Text;

namespace Stripe.Tests.Xunit
{
    public class events_fixture
    {
        // this was sent in the header Stripe-Signature along with the body of event.json in a test webhook
        internal string StripeSignature => "t=1493329224,v1=dca14f723dfa3bf47a310c3d6c3aff8bdb2534263d051dd2613ece097b8bdea4,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
        internal int EventTimestamp => 1493329224;
        internal string StripeJson { get; set; }
        internal string StripeSecret => "whsec_H68eTX02a4bCbiQOOoSAsIytOvuWZrQC";

        public events_fixture()
        {
            StripeJson = new StreamReader(
                typeof(when_constructing_an_event).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit.events.event.json"),
                Encoding.UTF8
            ).ReadToEnd();
        }
    }
}
