// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The billing cycle is the object that defines future billing cycle dates.
        /// </summary>
        [JsonProperty("billing_cycle")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle")]
#endif
        public CadenceCreateBillingCycleOptions BillingCycle { get; set; }

        /// <summary>
        /// Additional resource to include in the response.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The payer determines the entity financially responsible for the bill.
        /// </summary>
        [JsonProperty("payer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer")]
#endif
        public CadenceCreatePayerOptions Payer { get; set; }

        /// <summary>
        /// The settings associated with the cadence.
        /// </summary>
        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public CadenceCreateSettingsOptions Settings { get; set; }
    }
}
