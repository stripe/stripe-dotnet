// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class DebitReversalStatusTransitions : StripeEntity<DebitReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the DebitReversal changed status to <c>completed</c>.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CompletedAt { get; set; }
    }
}
