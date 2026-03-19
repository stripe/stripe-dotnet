// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceTransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer representing how much to transfer in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// One of: <c>eur</c>, <c>gbp</c>, or <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The balance to which funds are transferred.
        /// </summary>
        [JsonProperty("destination_balance")]
        [STJS.JsonPropertyName("destination_balance")]
        public BalanceTransferDestinationBalanceOptions DestinationBalance { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The balance from which funds are transferred, including details specific to the balance
        /// you choose.
        /// </summary>
        [JsonProperty("source_balance")]
        [STJS.JsonPropertyName("source_balance")]
        public BalanceTransferSourceBalanceOptions SourceBalance { get; set; }
    }
}
