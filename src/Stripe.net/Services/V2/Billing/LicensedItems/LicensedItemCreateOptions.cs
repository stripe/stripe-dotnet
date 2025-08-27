// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LicensedItemCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Description that customers will see in the invoice line item. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular billable item. Must be unique
        /// among billable items. Maximum length of 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

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
        /// Stripe Tax details.
        /// </summary>
        [JsonProperty("tax_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_details")]
#endif
        public LicensedItemCreateTaxDetailsOptions TaxDetails { get; set; }

        /// <summary>
        /// The unit to use when displaying prices for this billable item in places like Checkout.
        /// For example, set this field to "seat" for Checkout to display "(price) per seat", or
        /// "environment" to display "(price) per environment". Maximum length of 100 characters.
        /// </summary>
        [JsonProperty("unit_label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_label")]
#endif
        public string UnitLabel { get; set; }
    }
}
