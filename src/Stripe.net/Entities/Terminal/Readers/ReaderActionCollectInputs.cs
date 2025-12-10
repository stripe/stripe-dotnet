// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputs : StripeEntity<ReaderActionCollectInputs>, IHasMetadata
    {
        /// <summary>
        /// List of inputs to be collected.
        /// </summary>
        [JsonProperty("inputs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inputs")]
#endif
        public List<ReaderActionCollectInputsInput> Inputs { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }
    }
}
