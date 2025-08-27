// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePhaseAddInvoiceItemPeriodEnd : StripeEntity<SubscriptionSchedulePhaseAddInvoiceItemPeriodEnd>
    {
        /// <summary>
        /// A precise Unix timestamp for the end of the invoice item period. Must be greater than or
        /// equal to <c>period.start</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Select how to calculate the end of the invoice item period.
        /// One of: <c>min_item_period_end</c>, <c>phase_end</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
