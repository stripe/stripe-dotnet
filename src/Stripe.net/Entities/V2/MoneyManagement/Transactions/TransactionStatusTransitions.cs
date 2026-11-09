// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionStatusTransitions : StripeEntity<TransactionStatusTransitions>
    {
        /// <summary>
        /// The time at which the Transaction became <c>posted</c>. Only present when <c>status</c>
        /// is <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [STJS.JsonPropertyName("posted_at")]
        public DateTime? PostedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time at which the Transaction became <c>void</c>. Only present when <c>status</c> is
        /// <c>void</c>.
        /// </summary>
        [JsonProperty("void_at")]
        [STJS.JsonPropertyName("void_at")]
        public DateTime? VoidAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
