// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountPersonListOptions : ListOptions
    {
        /// <summary>
        /// Filters on the list of people returned based on the person's relationship to the
        /// account's company.
        /// </summary>
        [JsonProperty("relationship")]
        [STJS.JsonPropertyName("relationship")]
        public AccountPersonRelationshipOptions Relationship { get; set; }
    }
}
