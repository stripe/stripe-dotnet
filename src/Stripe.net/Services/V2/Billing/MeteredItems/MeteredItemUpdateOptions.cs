// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeteredItemUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Description that customers will see in the invoice line item. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular metered item. Maximum length of
        /// 200 characters. To remove the lookup_key from the object, set it to null in the request.
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
        /// Stripe Tax details.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public MeteredItemUpdateTaxDetailsOptions TaxDetails { get; set; }

        /// <summary>
        /// The unit to use when displaying prices for this billable item in places like Checkout.
        /// For example, set this field to "CPU-hour" for Checkout to display "(price) per
        /// CPU-hour", or "1 million events" to display "(price) per 1 million events". Maximum
        /// length of 100 characters. To remove the unit_label from the object, set it to null in
        /// the request.
        /// </summary>
        [JsonProperty("unit_label")]
        [STJS.JsonPropertyName("unit_label")]
        public string UnitLabel { get; set; }
    }
}
