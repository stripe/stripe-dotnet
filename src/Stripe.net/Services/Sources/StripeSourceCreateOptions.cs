using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceCreateOptions
    {
        /// <summary>
        /// REQUIRED: The type of the source to create.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alipay")]
        public string Alipay { get; set; }

        /// <summary>
        /// Amount associated with the source. This is the amount for which the source will be chargeable once ready. Required for single-use sources.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The currency associated with the source. This is the currency for which the source will be chargeable once ready.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The authentication flow of the source to create. Flow is one of <see cref="StripeSourceFlow" />. It is generally inferred unless a type supports multiple flows.
        /// </summary>
        [JsonProperty("flow")]
        public string Flow { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a source object. It can be useful for storing additional information about the source in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        // todo: owner

        // todo: redirect

        /// <summary>
        /// An optional token used to create the source. When passed, token properties will override source parameters.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// One of <see cref="StripeSourceUsage" />. Whether this source should be reusable or not. Some source types may or may not be reusable by construction, while other may leave the option at creation. If an incompatible value is passed, an error will be returned.
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}