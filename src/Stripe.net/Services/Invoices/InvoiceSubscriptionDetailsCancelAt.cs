// File generated from our OpenAPI spec
namespace Stripe
{
    public class InvoiceSubscriptionDetailsCancelAt : StringEnum
    {
        public static readonly InvoiceSubscriptionDetailsCancelAt MaxPeriodEnd = new InvoiceSubscriptionDetailsCancelAt("max_period_end");
        public static readonly InvoiceSubscriptionDetailsCancelAt MinPeriodEnd = new InvoiceSubscriptionDetailsCancelAt("min_period_end");

        private InvoiceSubscriptionDetailsCancelAt(string value)
            : base(value)
        {
        }
    }
}
