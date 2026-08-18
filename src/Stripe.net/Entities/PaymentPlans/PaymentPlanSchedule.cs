// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanSchedule : StripeEntity<PaymentPlanSchedule>
    {
        [JsonProperty("amounts_due")]
        [STJS.JsonPropertyName("amounts_due")]
        public PaymentPlanScheduleAmountsDue AmountsDue { get; set; }

        /// <summary>
        /// The type of schedule. Currently always <c>amounts_due</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
