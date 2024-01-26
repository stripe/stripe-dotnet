// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationLineItemOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>
        /// representing the line item's total price. If <c>tax_behavior=inclusive</c>, then this
        /// amount includes taxes. Otherwise, taxes are calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If provided, the product's <c>tax_code</c> will be used as the line item's
        /// <c>tax_code</c>.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The number of units of the item being purchased. Used to calculate the per-unit price
        /// from the total <c>amount</c> for the line. For example, if <c>amount=100</c> and
        /// <c>quantity=4</c>, the calculated unit price is 25.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item, which must be unique across the line items in
        /// the calculation. The reference helps identify each line item in exported <a
        /// href="https://stripe.com/docs/tax/reports">tax reports</a>.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. Defaults to <c>exclusive</c>.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID to use for this
        /// line item. If not provided, we will use the tax code from the provided <c>product</c>
        /// param. If neither <c>tax_code</c> nor <c>product</c> is provided, we will use the
        /// default tax code from your Tax Settings.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
