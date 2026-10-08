// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferMandateStatusTransitions : StripeEntity<InboundTransferMandateStatusTransitions>
    {
        /// <summary>
        /// When the mandate became active.
        /// </summary>
        [JsonProperty("activated_at")]
        [STJS.JsonPropertyName("activated_at")]
        public DateTime? ActivatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the mandate was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the mandate expired.
        /// </summary>
        [JsonProperty("expired_at")]
        [STJS.JsonPropertyName("expired_at")]
        public DateTime? ExpiredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
