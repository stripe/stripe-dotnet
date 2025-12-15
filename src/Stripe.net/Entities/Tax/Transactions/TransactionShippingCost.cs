// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionShippingCost : StripeEntity<TransactionShippingCost>
    {
        /// <summary>
        /// The shipping amount in the <a
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
        /// The amount of tax calculated for shipping, in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long AmountTax { get; set; }

        /// <summary>
        /// The ID of an existing <a
        /// href="https://docs.stripe.com/api/shipping_rates/object">ShippingRate</a>.
        /// </summary>
        [JsonProperty("shipping_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate")]
#endif
        public string ShippingRate { get; set; }

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
        /// Detailed account of taxes relevant to shipping cost. (It is not populated for the
        /// transaction resource object and will be removed in the next API version.).
        /// </summary>
        [JsonProperty("tax_breakdown")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_breakdown")]
#endif
        public List<TransactionShippingCostTaxBreakdown> TaxBreakdown { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID used for
        /// shipping.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }
    }
}
