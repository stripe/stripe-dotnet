// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanScheduleAmountsDueAmount : StripeEntity<PaymentPlanScheduleAmountsDueAmount>, IHasId
    {
        /// <summary>
        /// A description of this schedule entry.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        [STJS.JsonPropertyName("due_date")]
        public PaymentPlanScheduleAmountsDueAmountDueDate DueDate { get; set; }

        [JsonProperty("fixed_amount")]
        [STJS.JsonPropertyName("fixed_amount")]
        public PaymentPlanScheduleAmountsDueAmountFixedAmount FixedAmount { get; set; }

        /// <summary>
        /// Unique identifier for this schedule entry.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Percentage of the invoice total for this entry (0–100). Present when type is
        /// <c>percentage</c>.
        /// </summary>
        [JsonProperty("percentage")]
        [STJS.JsonPropertyName("percentage")]
        public decimal Percentage { get; set; }

        /// <summary>
        /// The type of this schedule entry. Either <c>fixed_amount</c> or <c>percentage</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
