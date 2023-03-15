// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsPaypalOptions : INestedOptions
    {
        [JsonProperty("billing_agreement_id")]
        public string BillingAgreementId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
