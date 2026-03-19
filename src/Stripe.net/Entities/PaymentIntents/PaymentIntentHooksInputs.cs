// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentHooksInputs : StripeEntity<PaymentIntentHooksInputs>
    {
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentHooksInputsTax Tax { get; set; }
    }
}
