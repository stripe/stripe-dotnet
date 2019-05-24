namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PayoutUpdateOptions : BaseOptions
    {
        /// <summary>
        /// A set of key-value pairs that you can attach to a payout object. It can be useful for
        /// storing additional information about the payout in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
