// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertAuthorizationRateDropDimension : StripeEntity<AlertAuthorizationRateDropDimension>
    {
        /// <summary>
        /// Populated when type is issuer.
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The type of the dimension. Determines which field in dimension_details is populated.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
