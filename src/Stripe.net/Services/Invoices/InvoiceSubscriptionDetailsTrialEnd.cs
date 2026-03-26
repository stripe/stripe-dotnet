// File generated from our OpenAPI spec
namespace Stripe
{
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(Infrastructure.STJStringEnumConverterFactory))]
    public class InvoiceSubscriptionDetailsTrialEnd : StringEnum
    {
        public static readonly InvoiceSubscriptionDetailsTrialEnd Now = new InvoiceSubscriptionDetailsTrialEnd("now");

        private InvoiceSubscriptionDetailsTrialEnd(string value)
            : base(value)
        {
        }
    }
}
