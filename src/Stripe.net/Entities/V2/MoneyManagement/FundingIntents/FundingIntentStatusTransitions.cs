// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentStatusTransitions : StripeEntity<FundingIntentStatusTransitions>
    {
        /// <summary>
        /// Time at which the FundingIntent entered the <c>canceled</c> status.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the FundingIntent entered the <c>processing</c> status.
        /// </summary>
        [JsonProperty("processing_at")]
        [STJS.JsonPropertyName("processing_at")]
        public DateTime? ProcessingAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the FundingIntent entered the <c>requires_action</c> status.
        /// </summary>
        [JsonProperty("requires_action_at")]
        [STJS.JsonPropertyName("requires_action_at")]
        public DateTime? RequiresActionAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the FundingIntent entered the <c>requires_confirmation</c> status.
        /// </summary>
        [JsonProperty("requires_confirmation_at")]
        [STJS.JsonPropertyName("requires_confirmation_at")]
        public DateTime? RequiresConfirmationAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the FundingIntent entered the <c>succeeded</c> status.
        /// </summary>
        [JsonProperty("succeeded_at")]
        [STJS.JsonPropertyName("succeeded_at")]
        public DateTime? SucceededAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the FundingIntent entered the <c>validating</c> status.
        /// </summary>
        [JsonProperty("validating_at")]
        [STJS.JsonPropertyName("validating_at")]
        public DateTime? ValidatingAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
