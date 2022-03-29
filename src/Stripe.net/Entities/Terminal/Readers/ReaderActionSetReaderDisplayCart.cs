// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderActionSetReaderDisplayCart : StripeEntity<ReaderActionSetReaderDisplayCart>
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// List of line items in the cart.
        /// </summary>
        [JsonProperty("line_items")]
        public List<ReaderActionSetReaderDisplayCartLineItem> LineItems { get; set; }

        /// <summary>
        /// Tax amount for the entire cart. A positive integer in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("tax")]
        public long? Tax { get; set; }

        /// <summary>
        /// Total amount for the entire cart, including tax. A positive integer in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
