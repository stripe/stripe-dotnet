// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountPersonListOptions : ListOptions
    {
        /// <summary>
        /// Filters on the list of people returned based on the person's relationship to the
        /// account's company.
        /// </summary>
        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif

        public AccountPersonRelationshipOptions Relationship { get; set; }
    }
}
