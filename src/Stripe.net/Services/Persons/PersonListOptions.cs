// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonListOptions : ListOptions
    {
        /// <summary>
        /// Filters on the list of people returned based on the person's relationship to the
        /// account's company.
        /// </summary>
        [JsonProperty("relationship")]
        public PersonRelationshipListOptions Relationship { get; set; }
    }
}
