using System.IO;
using System.Reflection;
using System.Text;

namespace Stripe.Tests.Xunit
{
    public class source_mandate_notifications_fixture
    {
        internal string StripeJson { get; set; }

        public source_mandate_notifications_fixture()
        {
            StripeJson = new StreamReader(
                typeof(when_constructing_a_source_mandate_notification).GetTypeInfo().Assembly.GetManifestResourceStream("Stripe.Tests.XUnit.source_mandate_notifications.source_mandate_notification.json"),
                Encoding.UTF8
            ).ReadToEnd();
        }
    }
}
