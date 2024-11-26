// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetails : StripeEntity<PaymentIntentAmountDetails>
    {
        [JsonProperty("tip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tip")]
#endif
        public PaymentIntentAmountDetailsTip Tip { get; set; }
    }
}
