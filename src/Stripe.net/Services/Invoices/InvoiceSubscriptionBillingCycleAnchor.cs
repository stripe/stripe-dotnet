// File generated from our OpenAPI spec
namespace Stripe
{
    public class InvoiceSubscriptionBillingCycleAnchor : StringEnum
    {
        public static readonly InvoiceSubscriptionBillingCycleAnchor Now = new InvoiceSubscriptionBillingCycleAnchor("now");
        public static readonly InvoiceSubscriptionBillingCycleAnchor Unchanged = new InvoiceSubscriptionBillingCycleAnchor("unchanged");

        private InvoiceSubscriptionBillingCycleAnchor(string value)
            : base(value)
        {
        }
    }
}
