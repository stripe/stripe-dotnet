// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount associated with the source.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SourceCardOptions Card { get; set; }

        /// <summary>
        /// Information about a mandate possibility attached to a source object (generally for bank
        /// debits) as well as its acceptance status.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public SourceMandateOptions Mandate { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by
        /// particular source types.
        /// </summary>
        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif
        public SourceOwnerOptions Owner { get; set; }

        /// <summary>
        /// Information about the items and shipping associated with the source. Required for
        /// transactional credit (for example Klarna) sources before you can charge it.
        /// </summary>
        [JsonProperty("source_order")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_order")]
#endif
        public SourceSourceOrderOptions SourceOrder { get; set; }
    }
}
