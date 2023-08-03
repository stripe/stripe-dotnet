// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceCurrencyOptions : StripeEntity<PriceCurrencyOptions>
    {
        /// <summary>
        /// When set, provides configuration for the amount to be adjusted by the customer during
        /// Checkout Sessions and Payment Links.
        /// </summary>
        [JsonProperty("custom_unit_amount")]
        public PriceCurrencyOptionsCustomUnitAmount CustomUnitAmount { get; set; }

        /// <summary>
        /// Only required if a <a
        /// href="https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)">default
        /// tax behavior</a> was not provided in the Stripe Tax settings. Specifies whether the
        /// price is considered inclusive of taxes or exclusive of taxes. One of <c>inclusive</c>,
        /// <c>exclusive</c>, or <c>unspecified</c>. Once specified as either <c>inclusive</c> or
        /// <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
        public List<PriceCurrencyOptionsTier> Tiers { get; set; }

        /// <summary>
        /// The unit amount in cents (or local equivalent) to be charged, represented as a whole
        /// integer if possible. Only set if <c>billing_scheme=per_unit</c>.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// The unit amount in cents (or local equivalent) to be charged, represented as a decimal
        /// string with at most 12 decimal places. Only set if <c>billing_scheme=per_unit</c>.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
