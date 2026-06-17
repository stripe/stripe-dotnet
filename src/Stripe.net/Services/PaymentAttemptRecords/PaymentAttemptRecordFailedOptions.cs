// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentAttemptRecordFailedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported refund failed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("failed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// Provides the reason for the refund failure. Possible values are:
        /// <c>lost_or_stolen_card</c>, <c>expired_or_canceled_card</c>,
        /// <c>charge_for_pending_refund_disputed</c>, <c>insufficient_funds</c>, <c>declined</c>,
        /// <c>merchant_request</c>, or <c>unknown</c>.
        /// One of: <c>charge_for_pending_refund_disputed</c>, <c>declined</c>,
        /// <c>expired_or_canceled_card</c>, <c>insufficient_funds</c>, <c>lost_or_stolen_card</c>,
        /// <c>merchant_request</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }
    }
}
