// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentHooksInputs : StripeEntity<PaymentIntentHooksInputs>
    {
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentHooksInputsTax Tax { get; set; }
    }
}
