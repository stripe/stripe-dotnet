// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsCardNetworkToken : StripeEntity<PaymentRecordPaymentMethodDetailsCardNetworkToken>
    {
        [JsonProperty("used")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("used")]
#endif
        public bool Used { get; set; }
    }
}
