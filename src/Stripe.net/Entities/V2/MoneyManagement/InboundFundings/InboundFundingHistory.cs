// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundFundingHistory : StripeEntity<InboundFundingHistory>, IHasId
    {
        /// <summary>
        /// Details of the transition to failed.
        /// </summary>
        [JsonProperty("check_failed")]
        [STJS.JsonPropertyName("check_failed")]
        public InboundFundingHistoryCheckFailed CheckFailed { get; set; }

        /// <summary>
        /// Details of the transition to processing.
        /// </summary>
        [JsonProperty("check_processing")]
        [STJS.JsonPropertyName("check_processing")]
        public InboundFundingHistoryCheckProcessing CheckProcessing { get; set; }

        /// <summary>
        /// Details of the transition to queued.
        /// </summary>
        [JsonProperty("check_queued")]
        [STJS.JsonPropertyName("check_queued")]
        public InboundFundingHistoryCheckQueued CheckQueued { get; set; }

        /// <summary>
        /// Details of the transition to returned.
        /// </summary>
        [JsonProperty("check_returned")]
        [STJS.JsonPropertyName("check_returned")]
        public InboundFundingHistoryCheckReturned CheckReturned { get; set; }

        /// <summary>
        /// Details of the transition to succeeded.
        /// </summary>
        [JsonProperty("check_succeeded")]
        [STJS.JsonPropertyName("check_succeeded")]
        public InboundFundingHistoryCheckSucceeded CheckSucceeded { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the history entry took effect.
        /// </summary>
        [JsonProperty("effective_at")]
        [STJS.JsonPropertyName("effective_at")]
        public DateTime EffectiveAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of this object.
        /// One of: <c>check_failed</c>, <c>check_processing</c>, <c>check_queued</c>,
        /// <c>check_returned</c>, or <c>check_succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
