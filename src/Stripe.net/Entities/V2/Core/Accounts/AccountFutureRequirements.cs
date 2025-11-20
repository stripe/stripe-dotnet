// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountFutureRequirements : StripeEntity<AccountFutureRequirements>
    {
        /// <summary>
        /// A list of requirements for the Account.
        /// </summary>
        [JsonProperty("entries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entries")]
#endif
        public List<AccountFutureRequirementsEntry> Entries { get; set; }

        /// <summary>
        /// The time at which the future requirements become effective.
        /// </summary>
        [JsonProperty("minimum_transition_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minimum_transition_date")]
#endif
        public DateTime? MinimumTransitionDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An object containing an overview of requirements for the Account.
        /// </summary>
        [JsonProperty("summary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("summary")]
#endif
        public AccountFutureRequirementsSummary Summary { get; set; }
    }
}
