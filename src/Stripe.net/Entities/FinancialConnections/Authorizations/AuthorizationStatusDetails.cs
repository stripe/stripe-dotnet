// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationStatusDetails : StripeEntity<AuthorizationStatusDetails>
    {
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public AuthorizationStatusDetailsActive Active { get; set; }

        [JsonProperty("inactive")]
        [STJS.JsonPropertyName("inactive")]
        public AuthorizationStatusDetailsInactive Inactive { get; set; }
    }
}
