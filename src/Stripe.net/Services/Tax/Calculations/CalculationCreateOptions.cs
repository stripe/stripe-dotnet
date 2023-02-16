// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CalculationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer to use for this calculation. If provided, the customer's
        /// address and tax IDs are copied to <c>customer_details</c>.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer, including address and tax IDs.
        /// </summary>
        [JsonProperty("customer_details")]
        public CalculationCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
        public List<CalculationLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// The boolean value that indicates if the calculation is a preview. If true, the
        /// calculation is not stored. If false, the calculation is stored for 48 hours. Defaults to
        /// true.
        /// </summary>
        [JsonProperty("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("tax_date")]
        public long? TaxDate { get; set; }
    }
}
