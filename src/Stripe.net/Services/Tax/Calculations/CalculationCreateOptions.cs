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

    public class CalculationCreateOptions : BaseOptions
    {
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
        /// The ID of an existing customer to use for this calculation. If provided, the customer's
        /// address and tax IDs are copied to <c>customer_details</c>.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer, including address and tax IDs.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public CalculationCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public List<CalculationLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Details about the address from which the goods are being shipped.
        /// </summary>
        [JsonProperty("ship_from_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ship_from_details")]
#endif
        public CalculationShipFromDetailsOptions ShipFromDetails { get; set; }

        /// <summary>
        /// Shipping cost details to be used for the calculation.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif
        public CalculationShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation. Measured in seconds since the Unix epoch. Can be up to 48 hours in the
        /// past, and up to 48 hours in the future.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? TaxDate { get; set; }
    }
}
