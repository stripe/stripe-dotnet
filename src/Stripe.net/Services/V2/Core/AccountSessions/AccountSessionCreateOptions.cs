// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the account to create an Account Session for.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The embedded components to enable for this Account Session.
        /// </summary>
        [JsonProperty("components")]
        [STJS.JsonPropertyName("components")]
        public AccountSessionCreateComponentsOptions Components { get; set; }

        /// <summary>
        /// Permissions to grant across the enabled components.
        /// </summary>
        [JsonProperty("scopes")]
        [STJS.JsonPropertyName("scopes")]
        public AccountSessionCreateScopesOptions Scopes { get; set; }
    }
}
