// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountStatusDetails : StripeEntity<AccountStatusDetails>
    {
        [JsonProperty("inactive")]
        [STJS.JsonPropertyName("inactive")]
        public AccountStatusDetailsInactive Inactive { get; set; }
    }
}
