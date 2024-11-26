// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The identifier of the account to create an Account Session for.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// Each key of the dictionary represents an embedded component, and each embedded component
        /// maps to its configuration (e.g. whether it has been enabled or not).
        /// </summary>
        [JsonProperty("components")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("components")]
#endif
        public AccountSessionComponentsOptions Components { get; set; }
    }
}
