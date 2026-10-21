// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormPaymentProcessing : StripeEntity<FormPaymentProcessing>
    {
        [JsonProperty("multi_processor")]
        [STJS.JsonPropertyName("multi_processor")]
        public FormPaymentProcessingMultiProcessor MultiProcessor { get; set; }

        /// <summary>
        /// How the connected account uses Stripe.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Why the connected account chose Stripe.
        /// </summary>
        [JsonProperty("stripe_selection_rationale")]
        [STJS.JsonPropertyName("stripe_selection_rationale")]
        public string StripeSelectionRationale { get; set; }
    }
}
