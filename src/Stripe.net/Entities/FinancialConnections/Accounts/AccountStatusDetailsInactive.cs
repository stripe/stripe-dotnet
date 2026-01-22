// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountStatusDetailsInactive : StripeEntity<AccountStatusDetailsInactive>
    {
        /// <summary>
        /// The action (if any) to relink the inactive Account.
        /// One of: <c>none</c>, or <c>relink_required</c>.
        /// </summary>
        [JsonProperty("action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("action")]
#endif
        public string Action { get; set; }

        /// <summary>
        /// The underlying cause of the Account being inactive.
        /// One of: <c>access_denied</c>, <c>access_expired</c>, <c>account_closed</c>,
        /// <c>account_unavailable</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("cause")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cause")]
#endif
        public string Cause { get; set; }
    }
}
