// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeteredItemCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Description that customers will see in the invoice line item. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Optional array of Meter dimensions to group event dimension keys for invoice line items.
        /// </summary>
        [JsonProperty("invoice_presentation_dimensions")]
        [STJS.JsonPropertyName("invoice_presentation_dimensions")]
        public List<string> InvoicePresentationDimensions { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular billable item. Must be unique
        /// among billable items. Maximum length of 200 characters.
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
        /// ID of the Meter that measures usage for this Metered Item.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Optional array of Meter segments to filter event dimension keys for billing.
        /// </summary>
        [JsonProperty("meter_segment_conditions")]
        [STJS.JsonPropertyName("meter_segment_conditions")]
        public List<MeteredItemCreateMeterSegmentConditionOptions> MeterSegmentConditions { get; set; }

        /// <summary>
        /// Stripe Tax details.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public MeteredItemCreateTaxDetailsOptions TaxDetails { get; set; }

        /// <summary>
        /// The unit to use when displaying prices for this billable item in places like Checkout.
        /// For example, set this field to "CPU-hour" for Checkout to display "(price) per
        /// CPU-hour", or "1 million events" to display "(price) per 1 million events". Maximum
        /// length of 100 characters.
        /// </summary>
        [JsonProperty("unit_label")]
        [STJS.JsonPropertyName("unit_label")]
        public string UnitLabel { get; set; }
    }
}
