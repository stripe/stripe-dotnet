using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format. You can unset individual keys if you POST an empty value for that key. You can clear all keys if you POST an empty value for metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Information about the owner of the payment instrument that may be used or required by particular source types.
        /// </summary>
        [JsonProperty("owner")]
        public StripeSourceOwner Owner { get; set; }

        /// <summary>
        /// Properties that can be updated on a Card Source.
        /// </summary>
        [JsonProperty("card")]
        public StripeSourceCardUpdateOptions Card { get; set; }
    }
}
