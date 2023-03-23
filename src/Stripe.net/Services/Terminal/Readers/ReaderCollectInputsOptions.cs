// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderCollectInputsOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// List of inputs to be collected using the Reader.
        /// </summary>
        [JsonProperty("inputs")]
        public List<ReaderInputOptions> Inputs { get; set; }

        /// <summary>
        /// Metadata related to the inputs to be collected.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
