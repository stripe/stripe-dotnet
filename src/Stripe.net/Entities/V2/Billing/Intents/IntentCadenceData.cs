// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCadenceData : StripeEntity<IntentCadenceData>
    {
        /// <summary>
        /// The billing cycle configuration for this Cadence.
        /// </summary>
        [JsonProperty("billing_cycle")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle")]
#endif
        public IntentCadenceDataBillingCycle BillingCycle { get; set; }

        /// <summary>
        /// Information about the payer for this Cadence.
        /// </summary>
        [JsonProperty("payer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer")]
#endif
        public IntentCadenceDataPayer Payer { get; set; }

        /// <summary>
        /// Settings for creating the Cadence.
        /// </summary>
        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public IntentCadenceDataSettings Settings { get; set; }
    }
}
