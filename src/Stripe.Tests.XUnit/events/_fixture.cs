using System.IO;
using System.Reflection;
using System.Text;

namespace Stripe.Tests.Xunit
{
    public class events_fixture
    {
        // this was sent in the header Stripe-Signature along with the body of event.json in a test webhook
        internal string StripeSignature => "t=1493329224,v1=86390d1392d759addd01dde4cfa5aa14d98a3b6cedd07a4aad73749cee26abe6,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
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
