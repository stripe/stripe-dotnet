// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CalculationLineItemOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer representing the line item's total price in the <a
        /// href="https://docs.stripe.com/currencies#minor-units">smallest currency unit</a>. If
        /// <c>tax_behavior=inclusive</c>, then this amount includes taxes. Otherwise, taxes are
        /// calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If provided, the product's <c>tax_code</c> will be used as the line item's
        /// <c>tax_code</c>.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// The number of units of the item being purchased. Used to calculate the per-unit price
        /// from the total <c>amount</c> for the line. For example, if <c>amount=100</c> and
        /// <c>quantity=4</c>, the calculated unit price is 25.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item, which must be unique across the line items in
        /// the calculation. The reference helps identify each line item in exported <a
        /// href="https://docs.stripe.com/tax/reports">tax reports</a>.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. Defaults to <c>exclusive</c>.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID to use for this
        /// line item. If not provided, we will use the tax code from the provided <c>product</c>
        /// param. If neither <c>tax_code</c> nor <c>product</c> is provided, we will use the
        /// default tax code from your Tax Settings.
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }
    }
}
