// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentHooks : StripeEntity<PaymentIntentHooks>
    {
        [JsonProperty("inputs")]
        [STJS.JsonPropertyName("inputs")]
        public PaymentIntentHooksInputs Inputs { get; set; }
    }
}
