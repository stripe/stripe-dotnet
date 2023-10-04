// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteMarkStaleOptions : BaseOptions
    {
        /// <summary>
        /// Reason the Quote is being marked stale.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
