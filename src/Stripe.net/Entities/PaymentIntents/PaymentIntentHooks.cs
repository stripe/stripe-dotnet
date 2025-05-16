// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentHooks : StripeEntity<PaymentIntentHooks>
    {
        [JsonProperty("inputs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inputs")]
#endif
        public PaymentIntentHooksInputs Inputs { get; set; }
    }
}
