// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class CreditReversalStatusTransitions : StripeEntity<CreditReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the CreditReversal changed status to <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }
    }
}
