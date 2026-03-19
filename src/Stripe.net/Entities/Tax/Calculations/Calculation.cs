// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A Tax Calculation allows you to calculate the tax to collect from your customer.
    ///
    /// Related guide: <a href="https://docs.stripe.com/tax/custom">Calculate tax in your custom
    /// payment flow</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Calculation : StripeEntity<Calculation>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the calculation.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Total amount after taxes in the <a
        /// href="https://docs.stripe.com/currencies#minor-units">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing <a
        /// href="https://docs.stripe.com/api/customers/object">Customer</a> used for the resource.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public CalculationCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax calculation will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The list of items the customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public StripeList<CalculationLineItem> LineItems { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The details of the ship from location, such as the address.
        /// </summary>
        [JsonProperty("ship_from_details")]
        [STJS.JsonPropertyName("ship_from_details")]
        public CalculationShipFromDetails ShipFromDetails { get; set; }

        /// <summary>
        /// The shipping cost details for the calculation.
        /// </summary>
        [JsonProperty("shipping_cost")]
        [STJS.JsonPropertyName("shipping_cost")]
        public CalculationShippingCost ShippingCost { get; set; }

        /// <summary>
        /// The amount of tax to be collected on top of the line item prices.
        /// </summary>
        [JsonProperty("tax_amount_exclusive")]
        [STJS.JsonPropertyName("tax_amount_exclusive")]
        public long TaxAmountExclusive { get; set; }

        /// <summary>
        /// The amount of tax already included in the line item prices.
        /// </summary>
        [JsonProperty("tax_amount_inclusive")]
        [STJS.JsonPropertyName("tax_amount_inclusive")]
        public long TaxAmountInclusive { get; set; }

        /// <summary>
        /// Breakdown of individual tax amounts that add up to the total.
        /// </summary>
        [JsonProperty("tax_breakdown")]
        [STJS.JsonPropertyName("tax_breakdown")]
        public List<CalculationTaxBreakdown> TaxBreakdown { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("tax_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime TaxDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
