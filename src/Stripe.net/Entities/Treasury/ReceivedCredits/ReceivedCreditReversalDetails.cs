// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReceivedCreditReversalDetails : StripeEntity<ReceivedCreditReversalDetails>
    {
        /// <summary>
        /// Time before which a ReceivedCredit can be reversed.
        /// </summary>
        [JsonProperty("deadline")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Set if a ReceivedCredit cannot be reversed.
        /// One of: <c>already_reversed</c>, <c>deadline_passed</c>, <c>network_restricted</c>,
        /// <c>other</c>, or <c>source_flow_restricted</c>.
        /// </summary>
        [JsonProperty("restricted_reason")]
        public string RestrictedReason { get; set; }
    }
}
