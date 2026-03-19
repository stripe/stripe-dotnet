// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentHooksInputsOptions : INestedOptions
    {
        /// <summary>
        /// Tax arguments for automations.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentHooksInputsTaxOptions Tax { get; set; }
    }
}
