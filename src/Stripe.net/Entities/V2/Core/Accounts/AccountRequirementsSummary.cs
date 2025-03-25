// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsSummary : StripeEntity<AccountRequirementsSummary>
    {
        /// <summary>
        /// An aggregate soonest point when the account will be impacted by not providing
        /// requirements.
        /// </summary>
        [JsonProperty("minimum_deadline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_deadline")]
#endif
        public AccountRequirementsSummaryMinimumDeadline MinimumDeadline { get; set; }
    }
}
