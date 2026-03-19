// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirementsSummaryMinimumDeadline : StripeEntity<AccountFutureRequirementsSummaryMinimumDeadline>
    {
        /// <summary>
        /// The current strictest status of all requirements on the Account.
        /// One of: <c>currently_due</c>, <c>eventually_due</c>, or <c>past_due</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The soonest RFC3339 date &amp; time UTC value a requirement can impact the Account.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public DateTime? Time { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
