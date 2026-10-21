// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SearchResultListContext : StripeEntity<SearchResultListContext>
    {
        /// <summary>
        /// Domain vocabulary relevant to the request, so that callers interpret the returned
        /// resources consistently with how Stripe defines these terms.
        /// </summary>
        [JsonProperty("business_concepts")]
        [STJS.JsonPropertyName("business_concepts")]
        public List<SearchResultListContextBusinessConcept> BusinessConcepts { get; set; }

        /// <summary>
        /// The business domain the request was matched to, for example "payments".
        /// </summary>
        [JsonProperty("domain")]
        [STJS.JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// High-level routing guidance for the agent. When <c>data</c> is empty, may advise how to
        /// refine the request or browse canonical resources.
        /// </summary>
        [JsonProperty("guidance")]
        [STJS.JsonPropertyName("guidance")]
        public string Guidance { get; set; }
    }
}
