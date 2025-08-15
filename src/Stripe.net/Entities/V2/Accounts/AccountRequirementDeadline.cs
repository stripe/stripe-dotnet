// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementDeadline : StripeEntity<AccountRequirementDeadline>
    {
        /// <summary>
        /// Machine-readable version of the deadline.
        /// </summary>
        [JsonProperty("due_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("due_at")]
#endif
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// Closed Enum. Human-readable description of the deadline.
        /// One of: <c>conditionally_due</c>, <c>currently_due</c>, or <c>deadline_past_due</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
