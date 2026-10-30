// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsCapitalFinancingApplication : StripeEntity<AccountSessionComponentsCapitalFinancingApplication>
    {
        /// <summary>
        /// Whether this embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The scopes available to this embedded component.
        /// </summary>
        [JsonProperty("scopes")]
        [STJS.JsonPropertyName("scopes")]
        public AccountSessionComponentsCapitalFinancingApplicationScopes Scopes { get; set; }
    }
}
