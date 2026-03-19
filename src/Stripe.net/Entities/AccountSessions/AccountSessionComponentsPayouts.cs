// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsPayouts : StripeEntity<AccountSessionComponentsPayouts>
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public AccountSessionComponentsPayoutsFeatures Features { get; set; }
    }
}
