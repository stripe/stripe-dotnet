// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Tax Calculation allows you to calculate the tax to collect from your customer.
    ///
    /// Related guide: <a href="https://stripe.com/docs/tax/custom">Calculate tax in your custom
    /// payment flow</a>.
    /// </summary>
    public class Calculation : StripeEntity<Calculation>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the calculation.
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
        /// Total amount after taxes in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif

        public long AmountTotal { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/customers/object">Customer</a> used for the resource.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif

        public CalculationCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax calculation will expire.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The list of items the customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif

        public StripeList<CalculationLineItem> LineItems { get; set; }

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
        /// The details of the ship from location, such as the address.
        /// </summary>
        [JsonProperty("ship_from_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ship_from_details")]
#endif

        public CalculationShipFromDetails ShipFromDetails { get; set; }

        /// <summary>
        /// The shipping cost details for the calculation.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif

        public CalculationShippingCost ShippingCost { get; set; }

        /// <summary>
        /// The amount of tax to be collected on top of the line item prices.
        /// </summary>
        [JsonProperty("tax_amount_exclusive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amount_exclusive")]
#endif

        public long TaxAmountExclusive { get; set; }

        /// <summary>
        /// The amount of tax already included in the line item prices.
        /// </summary>
        [JsonProperty("tax_amount_inclusive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amount_inclusive")]
#endif

        public long TaxAmountInclusive { get; set; }

        /// <summary>
        /// Breakdown of individual tax amounts that add up to the total.
        /// </summary>
        [JsonProperty("tax_breakdown")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_breakdown")]
#endif

        public List<CalculationTaxBreakdown> TaxBreakdown { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation.
        /// </summary>
        [JsonProperty("tax_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_date")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime TaxDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
