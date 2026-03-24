// File generated from our OpenAPI spec
namespace Stripe
{
    public class InvoiceSubscriptionDetailsBillingCycleAnchor : StringEnum
    {
        public static readonly InvoiceSubscriptionDetailsBillingCycleAnchor Now = new InvoiceSubscriptionDetailsBillingCycleAnchor("now");
        public static readonly InvoiceSubscriptionDetailsBillingCycleAnchor Unchanged = new InvoiceSubscriptionDetailsBillingCycleAnchor("unchanged");

        private InvoiceSubscriptionDetailsBillingCycleAnchor(string value)
            : base(value)
        {
        }
    }
}
