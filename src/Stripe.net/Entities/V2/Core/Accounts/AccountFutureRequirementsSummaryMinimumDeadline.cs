// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountFutureRequirementsSummaryMinimumDeadline : StripeEntity<AccountFutureRequirementsSummaryMinimumDeadline>
    {
        /// <summary>
        /// The current strictest status of all requirements on the Account.
        /// One of: <c>currently_due</c>, <c>eventually_due</c>, or <c>past_due</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The soonest RFC3339 date &amp; time UTC value a requirement can impact the Account.
        /// </summary>
        [JsonProperty("time")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("time")]
#endif
        public DateTime? Time { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
