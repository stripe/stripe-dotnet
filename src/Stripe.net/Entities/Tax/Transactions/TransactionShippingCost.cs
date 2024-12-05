// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransactionShippingCost : StripeEntity<TransactionShippingCost>
    {
        /// <summary>
        /// The shipping amount in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>. If
        /// <c>tax_behavior=inclusive</c>, then this amount includes taxes. Otherwise, taxes were
        /// calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The amount of tax calculated for shipping, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/shipping_rates/object">ShippingRate</a>.
        /// </summary>
        [JsonProperty("shipping_rate")]
        public string ShippingRate { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. If <c>tax_behavior=inclusive</c>,
        /// then the amount includes taxes.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Detailed account of taxes relevant to shipping cost. (It is not populated for the
        /// transaction resource object and will be removed in the next API version.).
        /// </summary>
        [JsonProperty("tax_breakdown")]
        public List<TransactionShippingCostTaxBreakdown> TaxBreakdown { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID used for
        /// shipping.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
