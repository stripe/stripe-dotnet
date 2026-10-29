// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanScheduleAmountsDueAmountDueDateRelative : StripeEntity<PaymentPlanScheduleAmountsDueAmountDueDateRelative>
    {
        /// <summary>
        /// The number of intervals after the invoice is finalized that this entry is due.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// The interval unit: <c>day</c>, <c>week</c>, <c>month</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }
    }
}
