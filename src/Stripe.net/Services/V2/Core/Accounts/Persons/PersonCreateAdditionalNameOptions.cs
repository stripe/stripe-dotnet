// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonCreateAdditionalNameOptions : INestedOptions
    {
        /// <summary>
        /// The person's full name.
        /// </summary>
        [JsonProperty("full_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("full_name")]
#endif
        public string FullName { get; set; }

        /// <summary>
        /// The person's first or given name.
        /// </summary>
        [JsonProperty("given_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
#endif
        public string GivenName { get; set; }

        /// <summary>
        /// The purpose or type of the additional name.
        /// One of: <c>alias</c>, or <c>maiden</c>.
        /// </summary>
        [JsonProperty("purpose")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purpose")]
#endif
        public string Purpose { get; set; }

        /// <summary>
        /// The person's last or family name.
        /// </summary>
        [JsonProperty("surname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
#endif
        public string Surname { get; set; }
    }
}
