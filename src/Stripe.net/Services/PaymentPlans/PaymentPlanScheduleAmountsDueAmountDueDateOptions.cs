// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentPlanScheduleAmountsDueAmountDueDateOptions : INestedOptions
    {
        /// <summary>
        /// Unix timestamp. Required when type is 'absolute'.
        /// </summary>
        [JsonProperty("absolute")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("absolute")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Absolute { get; set; }

        /// <summary>
        /// Required when type is 'relative'.
        /// </summary>
        [JsonProperty("relative")]
        [STJS.JsonPropertyName("relative")]
        public PaymentPlanScheduleAmountsDueAmountDueDateRelativeOptions Relative { get; set; }

        /// <summary>
        /// Either 'absolute' or 'relative'.
        /// One of: <c>absolute</c>, or <c>relative</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
