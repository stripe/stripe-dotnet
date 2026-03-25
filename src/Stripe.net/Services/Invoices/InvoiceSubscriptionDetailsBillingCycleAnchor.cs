// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
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
