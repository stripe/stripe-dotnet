// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderActionCollectInputs : StripeEntity<ReaderActionCollectInputs>, IHasMetadata
    {
        /// <summary>
        /// List of inputs to be collected.
        /// </summary>
        [JsonProperty("inputs")]
        public List<ReaderActionCollectInputsInput> Inputs { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}