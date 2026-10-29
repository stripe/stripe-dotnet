// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanInstallment : StripeEntity<PaymentPlanInstallment>, IHasId
    {
        /// <summary>
        /// Amount owed for this installment, in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount_due")]
        [STJS.JsonPropertyName("amount_due")]
        public long AmountDue { get; set; }

        /// <summary>
        /// Amount forgiven for this installment, in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount_forgiven")]
        [STJS.JsonPropertyName("amount_forgiven")]
        public long AmountForgiven { get; set; }

        /// <summary>
        /// Amount already paid toward this installment, in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount_paid")]
        [STJS.JsonPropertyName("amount_paid")]
        public long AmountPaid { get; set; }

        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A description of this installment.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Unix timestamp when this installment is due. Omitted for installments with no due date.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("due_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime DueDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Unique identifier for the installment.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Unix timestamp when this installment was paid.
        /// </summary>
        [JsonProperty("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("paid_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PaidAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The status of this installment. One of <c>open</c>, <c>paid</c>, <c>past_due</c>, or
        /// <c>canceled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
