// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Tax <c>Calculation</c> allows you to calculate the tax to collect from your customer.
    /// </summary>
    public class TaxCalculation : StripeEntity<TaxCalculation>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the calculation.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Total after taxes.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing <a
        /// href="https://stripe.com/docs/api/customers/object">Customer</a> used for the resource.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("customer_details")]
        public TaxCalculationCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax calculation will expire. Empty if the calculation is
        /// an unsaved preview.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The list of items the customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
        public StripeList<LineItem> LineItems { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A custom unique identifier, such as 'myOrder_123'.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The amount of tax to be collected on top of the line item prices.
        /// </summary>
        [JsonProperty("tax_amount_exclusive")]
        public long TaxAmountExclusive { get; set; }

        /// <summary>
        /// The amount of tax already included in the line item prices.
        /// </summary>
        [JsonProperty("tax_amount_inclusive")]
        public long TaxAmountInclusive { get; set; }

        /// <summary>
        /// Breakdown of individual tax amounts that add up to the total.
        /// </summary>
        [JsonProperty("tax_breakdown")]
        public List<TaxCalculationTaxBreakdown> TaxBreakdown { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime TaxDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
