// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CalculationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer to use for this calculation. If provided, the customer's
        /// address and tax IDs are copied to <c>customer_details</c>.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer, including address and tax IDs.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public CalculationCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing. You can pass up to 100 line items, or 1,000
        /// if your account has an increased limit.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<CalculationLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Details about the address from which the goods are being shipped.
        /// </summary>
        [JsonProperty("ship_from_details")]
        [STJS.JsonPropertyName("ship_from_details")]
        public CalculationShipFromDetailsOptions ShipFromDetails { get; set; }

        /// <summary>
        /// Shipping cost details to be used for the calculation.
        /// </summary>
        [JsonProperty("shipping_cost")]
        [STJS.JsonPropertyName("shipping_cost")]
        public CalculationShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// The calculation uses the tax rules and rates that are in effect at this timestamp. You
        /// can use a date up to 31 days in the past or up to 31 days in the future. If you use a
        /// future date, Stripe doesn't guarantee that the expected tax rules and rate being used
        /// match the actual rules and rate that will be in effect on that date. We deploy tax
        /// changes before their effective date, but not within a fixed window.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("tax_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? TaxDate { get; set; }
    }
}
