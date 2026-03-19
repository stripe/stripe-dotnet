// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderCartOptions : INestedOptions
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
        /// Array of line items to display.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<ReaderCartLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// The amount of tax in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public long? Tax { get; set; }

        /// <summary>
        /// Total balance of cart due in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long? Total { get; set; }
    }
}
