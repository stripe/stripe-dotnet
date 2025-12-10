// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerPaymentSourceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
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
        /// Please refer to full <a href="https://api.stripe.com">documentation</a> instead.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public string Source { get; set; }

        [JsonProperty("validate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validate")]
#endif
        public bool? Validate { get; set; }
    }
}
