// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentCadenceData : StripeEntity<IntentCadenceData>
    {
        /// <summary>
        /// The billing cycle configuration for this Cadence.
        /// </summary>
        [JsonProperty("billing_cycle")]
        [STJS.JsonPropertyName("billing_cycle")]
        public IntentCadenceDataBillingCycle BillingCycle { get; set; }

        /// <summary>
        /// Information about the payer for this Cadence.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public IntentCadenceDataPayer Payer { get; set; }

        /// <summary>
        /// Settings for creating the Cadence.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public IntentCadenceDataSettings Settings { get; set; }
    }
}
