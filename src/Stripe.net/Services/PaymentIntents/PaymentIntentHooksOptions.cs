// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentHooksOptions : INestedOptions
    {
        /// <summary>
        /// Arguments passed in automations.
        /// </summary>
        [JsonProperty("inputs")]
        [STJS.JsonPropertyName("inputs")]
        public PaymentIntentHooksInputsOptions Inputs { get; set; }
    }
}
