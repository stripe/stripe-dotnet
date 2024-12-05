// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderCartOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Array of line items that were purchased.
        /// </summary>
        [JsonProperty("line_items")]
        public List<ReaderCartLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// The amount of tax in cents.
        /// </summary>
        [JsonProperty("tax")]
        public long? Tax { get; set; }

        /// <summary>
        /// Total balance of cart due in cents.
        /// </summary>
        [JsonProperty("total")]
        public long? Total { get; set; }
    }
}
