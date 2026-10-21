// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListContextBusinessConcept : StripeEntity<SearchResultListContextBusinessConcept>
    {
        /// <summary>
        /// What the term means in the context of this domain.
        /// </summary>
        [JsonProperty("definition")]
        [STJS.JsonPropertyName("definition")]
        public string Definition { get; set; }

        /// <summary>
        /// The name of the concept, for example "decline reason".
        /// </summary>
        [JsonProperty("term")]
        [STJS.JsonPropertyName("term")]
        public string Term { get; set; }
    }
}
