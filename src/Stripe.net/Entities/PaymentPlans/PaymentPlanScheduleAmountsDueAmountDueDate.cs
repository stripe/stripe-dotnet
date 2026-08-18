// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanScheduleAmountsDueAmountDueDate : StripeEntity<PaymentPlanScheduleAmountsDueAmountDueDate>
    {
        /// <summary>
        /// Unix timestamp of the due date. Present when type is <c>absolute</c>.
        /// </summary>
        [JsonProperty("absolute")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("absolute")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Absolute { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("relative")]
        [STJS.JsonPropertyName("relative")]
        public PaymentPlanScheduleAmountsDueAmountDueDateRelative Relative { get; set; }

        /// <summary>
        /// The type of due date. Either <c>absolute</c> or <c>relative</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
