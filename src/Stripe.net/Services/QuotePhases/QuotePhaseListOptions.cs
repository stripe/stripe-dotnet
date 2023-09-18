// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePhaseListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the quote whose phases will be retrieved.
        /// </summary>
        [JsonProperty("quote")]
        public string Quote { get; set; }
    }
}
