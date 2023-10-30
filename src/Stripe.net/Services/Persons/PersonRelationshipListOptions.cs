// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRelationshipListOptions : INestedOptions
    {
        /// <summary>
        /// A filter on the list of people returned based on whether these people are directors of
        /// the account's company.
        /// </summary>
        [JsonProperty("director")]
        public bool? Director { get; set; }

        /// <summary>
        /// A filter on the list of people returned based on whether these people are executives of
        /// the account's company.
        /// </summary>
        [JsonProperty("executive")]
        public bool? Executive { get; set; }

        /// <summary>
        /// A filter on the list of people returned based on whether these people are legal
        /// guardians of the account's representative.
        /// </summary>
        [JsonProperty("legal_guardian")]
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// A filter on the list of people returned based on whether these people are owners of the
        /// account's company.
        /// </summary>
        [JsonProperty("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// A filter on the list of people returned based on whether these people are the
        /// representative of the account's company.
        /// </summary>
        [JsonProperty("representative")]
        public bool? Representative { get; set; }
    }
}
