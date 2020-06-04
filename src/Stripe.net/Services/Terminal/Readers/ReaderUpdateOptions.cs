namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The new label of the reader.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
