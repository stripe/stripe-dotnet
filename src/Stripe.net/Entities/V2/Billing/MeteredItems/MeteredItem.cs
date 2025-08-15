// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A MeteredItem represents a billable item whose pricing is based on usage, measured by a
    /// Meter. You can use RateCards to specify the pricing and create Subscriptions to these
    /// items.
    /// </summary>
    public class MeteredItem : StripeEntity<MeteredItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// The ID of the MeteredItem.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// Optional array of Meter dimensions to group event dimension keys for invoice line items.
        /// </summary>
        [JsonProperty("invoice_presentation_dimensions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_presentation_dimensions")]
#endif
        public List<string> InvoicePresentationDimensions { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular billable item. Maximum length of
        /// 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// ID of the Meter that measures usage for this MeteredItem.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif
        public string Meter { get; set; }

        /// <summary>
        /// Optional array of Meter segments to filter event dimension keys for billing.
        /// </summary>
        [JsonProperty("meter_segment_conditions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter_segment_conditions")]
#endif
        public List<MeteredItemMeterSegmentCondition> MeterSegmentConditions { get; set; }

        /// <summary>
        /// Stripe Tax details.
        /// </summary>
        [JsonProperty("tax_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_details")]
#endif
        public MeteredItemTaxDetails TaxDetails { get; set; }

        /// <summary>
        /// The unit to use when displaying prices for this billable item in places like Checkout.
        /// For example, set this field to "CPU-hour" for Checkout to display "(price) per
        /// CPU-hour", or "1 million events" to display "(price) per 1 million events". Maximum
        /// length of 100 characters.
        /// </summary>
        [JsonProperty("unit_label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_label")]
#endif
        public string UnitLabel { get; set; }
    }
}
