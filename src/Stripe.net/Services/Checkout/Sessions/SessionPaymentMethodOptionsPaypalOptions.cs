// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsPaypalOptions : INestedOptions
    {
        [JsonProperty("billing_agreement_id")]
        public string BillingAgreementId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
