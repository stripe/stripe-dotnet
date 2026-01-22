// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationStatusDetails : StripeEntity<AuthorizationStatusDetails>
    {
        [JsonProperty("inactive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inactive")]
#endif
        public AuthorizationStatusDetailsInactive Inactive { get; set; }
    }
}
