// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountStatusDetails : StripeEntity<AccountStatusDetails>
    {
        [JsonProperty("inactive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inactive")]
#endif
        public AccountStatusDetailsInactive Inactive { get; set; }
    }
}
