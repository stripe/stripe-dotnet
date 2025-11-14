// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountFutureRequirementsSummary : StripeEntity<AccountFutureRequirementsSummary>
    {
        /// <summary>
        /// The soonest date and time a requirement on the Account will become <c>past due</c>.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("minimum_deadline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_deadline")]
#endif
        public AccountFutureRequirementsSummaryMinimumDeadline MinimumDeadline { get; set; }
    }
}
