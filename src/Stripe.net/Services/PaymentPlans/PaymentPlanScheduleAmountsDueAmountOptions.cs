// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentPlanScheduleAmountsDueAmountOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// Optional description for this installment.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// When this installment is due.
        /// </summary>
        [JsonProperty("due_date")]
        [STJS.JsonPropertyName("due_date")]
        public PaymentPlanScheduleAmountsDueAmountDueDateOptions DueDate { get; set; }

        /// <summary>
        /// Required when type is 'fixed_amount'.
        /// </summary>
        [JsonProperty("fixed_amount")]
        [STJS.JsonPropertyName("fixed_amount")]
        public PaymentPlanScheduleAmountsDueAmountFixedAmountOptions FixedAmount { get; set; }

        /// <summary>
        /// Optional stable identifier for the installment entry.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The installment percentage of the total. Required when type is 'percentage'.
        /// </summary>
        [JsonProperty("percentage")]
        [STJS.JsonPropertyName("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Either 'fixed_amount' or 'percentage'.
        /// One of: <c>fixed_amount</c>, or <c>percentage</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
