// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountFutureRequirements : StripeEntity<AccountFutureRequirements>
    {
        /// <summary>
        /// A list of requirements for the Account.
        /// </summary>
        [JsonProperty("entries")]
        [STJS.JsonPropertyName("entries")]
        public List<AccountFutureRequirementsEntry> Entries { get; set; }

        /// <summary>
        /// The time at which the future requirements become effective.
        /// </summary>
        [JsonProperty("minimum_transition_date")]
        [STJS.JsonPropertyName("minimum_transition_date")]
        public DateTime? MinimumTransitionDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An object containing an overview of requirements for the Account.
        /// </summary>
        [JsonProperty("summary")]
        [STJS.JsonPropertyName("summary")]
        public AccountFutureRequirementsSummary Summary { get; set; }
    }
}
