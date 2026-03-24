// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsTaxRegistrations : StripeEntity<AccountSessionComponentsTaxRegistrations>
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public AccountSessionComponentsTaxRegistrationsFeatures Features { get; set; }
    }
}
