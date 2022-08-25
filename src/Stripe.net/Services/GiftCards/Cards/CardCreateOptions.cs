// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The active state for the new gift card, defaults to false. The active state can be
        /// updated after creation.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Related objects which created this gift card.
        /// </summary>
        [JsonProperty("created_by")]
        public CardCreatedByOptions CreatedBy { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The initial amount to load onto the new gift card, defaults to 0.
        /// </summary>
        [JsonProperty("initial_amount")]
        public long? InitialAmount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
