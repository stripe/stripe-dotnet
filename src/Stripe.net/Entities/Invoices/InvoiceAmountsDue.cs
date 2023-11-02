// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceAmountsDue : StripeEntity<InvoiceAmountsDue>
    {
        /// <summary>
        /// Incremental amount due for this payment in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The amount in cents (or local equivalent) that was paid for this payment.
        /// </summary>
        [JsonProperty("amount_paid")]
        public long AmountPaid { get; set; }

        /// <summary>
        /// The difference between the payment’s amount and amount_paid, in cents (or local
        /// equivalent).
        /// </summary>
        [JsonProperty("amount_remaining")]
        public long AmountRemaining { get; set; }

        /// <summary>
        /// Number of days from when invoice is finalized until the payment is due.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Date on which a payment plan’s payment is due.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Timestamp when the payment was paid.
        /// </summary>
        [JsonProperty("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// The status of the payment, one of <c>open</c>, <c>paid</c>, or <c>past_due</c>.
        /// One of: <c>open</c>, <c>paid</c>, or <c>past_due</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
