// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditReversalDetails : StripeEntity<ReceivedCreditReversalDetails>
    {
        /// <summary>
        /// Time before which a ReceivedCredit can be reversed.
        /// </summary>
        [JsonProperty("deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deadline")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Set if a ReceivedCredit cannot be reversed.
        /// One of: <c>already_reversed</c>, <c>deadline_passed</c>, <c>network_restricted</c>,
        /// <c>other</c>, or <c>source_flow_restricted</c>.
        /// </summary>
        [JsonProperty("restricted_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("restricted_reason")]
#endif
        public string RestrictedReason { get; set; }
    }
}
