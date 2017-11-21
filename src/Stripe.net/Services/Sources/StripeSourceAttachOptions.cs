using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceAttachOptions : StripeBaseOptions
    {
        /// <summary>
        /// REQUIRED: The identifier of the source to be attached.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
