// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequestReview : StripeEntity<ApprovalRequestReview>
    {
        /// <summary>
        /// The reason provided by the reviewer.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The result of the review.
        /// One of: <c>approved</c>, or <c>rejected</c>.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// Timestamp when the review was performed.
        /// </summary>
        [JsonProperty("reviewed_at")]
        [STJS.JsonPropertyName("reviewed_at")]
        public DateTime ReviewedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The reviewer who performed the review.
        /// </summary>
        [JsonProperty("reviewed_by")]
        [STJS.JsonPropertyName("reviewed_by")]
        public ApprovalRequestReviewReviewedBy ReviewedBy { get; set; }
    }
}
