// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateCadenceDataOptions : INestedOptions
    {
        /// <summary>
        /// The billing cycle configuration for this Cadence.
        /// </summary>
        [JsonProperty("billing_cycle")]
        [STJS.JsonPropertyName("billing_cycle")]
        public IntentCreateCadenceDataBillingCycleOptions BillingCycle { get; set; }

        /// <summary>
        /// Information about the payer for this Cadence.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public IntentCreateCadenceDataPayerOptions Payer { get; set; }

        /// <summary>
        /// Settings for creating the Cadence.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public IntentCreateCadenceDataSettingsOptions Settings { get; set; }
    }
}
