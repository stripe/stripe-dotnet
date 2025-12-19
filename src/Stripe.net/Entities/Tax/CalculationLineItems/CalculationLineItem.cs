// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CalculationLineItem : StripeEntity<CalculationLineItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The line item amount in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. If
        /// <c>tax_behavior=inclusive</c>, then this amount includes taxes. Otherwise, taxes were
        /// calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// The amount of tax calculated for this line item, in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long AmountTax { get; set; }

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
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A tax location for a line item that acts as a performance location. This indicates that
        /// the line item might be taxed at the place where it is being performed at. This is
        /// helpful for events or other services being performed at non-customer addresses like
        /// venues or offices. This can be left empty for tax codes that do not require a tax
        /// location. For tax codes where the location requirement is "optional", this would
        /// override the customer address in most use cases.
        /// </summary>
        [JsonProperty("performance_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("performance_location")]
#endif
        public string PerformanceLocation { get; set; }

        /// <summary>
        /// The ID of an existing <a href="https://docs.stripe.com/api/products/object">Product</a>.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif
        public string Product { get; set; }

        /// <summary>
        /// The number of units of the item being purchased. For reversals, this is the quantity
        /// reversed.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. If <c>tax_behavior=inclusive</c>,
        /// then the amount includes taxes.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Detailed account of taxes relevant to this line item.
        /// </summary>
        [JsonProperty("tax_breakdown")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_breakdown")]
#endif
        public List<CalculationLineItemTaxBreakdown> TaxBreakdown { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID used for this
        /// resource.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }
    }
}
