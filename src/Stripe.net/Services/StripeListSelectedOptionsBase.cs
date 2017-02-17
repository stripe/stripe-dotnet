using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Base class for listing requests which allow filtering based on specific IDs.
    /// </summary>
    public abstract class StripeListSelectedOptionsBase : StripeListOptions
    {
        /// <summary>
        /// Gets or sets a list of ids to return.
        /// </summary>
        [JsonProperty("ids")]
        public string[] Ids { get; set; }
    }
}
