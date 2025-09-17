// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionStatusTransitions : StripeEntity<TransactionStatusTransitions>
    {
        /// <summary>
        /// The time at which the Transaction became posted. Only present if status == posted.
        /// </summary>
        [JsonProperty("posted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
#endif
        public DateTime PostedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time at which the Transaction became void. Only present if status == void.
        /// </summary>
        [JsonProperty("void_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("void_at")]
#endif
        public DateTime VoidAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
