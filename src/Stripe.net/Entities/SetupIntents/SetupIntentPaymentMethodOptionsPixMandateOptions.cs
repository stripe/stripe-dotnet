// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentPaymentMethodOptionsPixMandateOptions : StripeEntity<SetupIntentPaymentMethodOptionsPixMandateOptions>
    {
        /// <summary>
        /// Amount to be charged for future payments.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Determines if the amount includes the IOF tax.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
        [STJS.JsonPropertyName("amount_includes_iof")]
        public string AmountIncludesIof { get; set; }

        /// <summary>
        /// Type of amount.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
        [STJS.JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Date when the mandate expires and no further payments will be charged, in
        /// <c>YYYY-MM-DD</c>.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// Schedule at which the future payments will be charged.
        /// One of: <c>halfyearly</c>, <c>monthly</c>, <c>quarterly</c>, <c>weekly</c>, or
        /// <c>yearly</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
        [STJS.JsonPropertyName("payment_schedule")]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Subscription name displayed to buyers in their bank app.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Start date of the mandate, in <c>YYYY-MM-DD</c>.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
