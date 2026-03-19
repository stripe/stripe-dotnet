// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonCreateAdditionalNameOptions : INestedOptions
    {
        /// <summary>
        /// The person's full name.
        /// </summary>
        [JsonProperty("full_name")]
        [STJS.JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// The person's first or given name.
        /// </summary>
        [JsonProperty("given_name")]
        [STJS.JsonPropertyName("given_name")]
        public string GivenName { get; set; }

        /// <summary>
        /// The purpose or type of the additional name.
        /// One of: <c>alias</c>, or <c>maiden</c>.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// The person's last or family name.
        /// </summary>
        [JsonProperty("surname")]
        [STJS.JsonPropertyName("surname")]
        public string Surname { get; set; }
    }
}
