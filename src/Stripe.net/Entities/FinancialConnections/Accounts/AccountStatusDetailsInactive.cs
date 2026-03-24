// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountStatusDetailsInactive : StripeEntity<AccountStatusDetailsInactive>
    {
        /// <summary>
        /// The action (if any) to relink the inactive Account.
        /// One of: <c>none</c>, or <c>relink_required</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// The underlying cause of the Account being inactive.
        /// One of: <c>access_denied</c>, <c>access_expired</c>, <c>account_closed</c>,
        /// <c>account_unavailable</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("cause")]
        [STJS.JsonPropertyName("cause")]
        public string Cause { get; set; }
    }
}
