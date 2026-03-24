// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CadenceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The billing cycle is the object that defines future billing cycle dates.
        /// </summary>
        [JsonProperty("billing_cycle")]
        [STJS.JsonPropertyName("billing_cycle")]
        public CadenceCreateBillingCycleOptions BillingCycle { get; set; }

        /// <summary>
        /// Additional resource to include in the response.
        /// One of: <c>invoice_discount_rules</c>, or <c>settings_data</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// A lookup key used to retrieve cadences dynamically from a static string. Maximum length
        /// of 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The payer determines the entity financially responsible for the bill.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public CadenceCreatePayerOptions Payer { get; set; }

        /// <summary>
        /// The settings associated with the cadence.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public CadenceCreateSettingsOptions Settings { get; set; }
    }
}
