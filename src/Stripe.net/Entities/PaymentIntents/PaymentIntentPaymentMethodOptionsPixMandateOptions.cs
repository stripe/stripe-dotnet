// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsPixMandateOptions : StripeEntity<PaymentIntentPaymentMethodOptionsPixMandateOptions>
    {
        /// <summary>
        /// Amount to be charged for future payments.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Determines if the amount includes the IOF tax.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_includes_iof")]
#endif
        public string AmountIncludesIof { get; set; }

        /// <summary>
        /// Type of amount.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_type")]
#endif
        public string AmountType { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Date when the mandate expires and no further payments will be charged, in
        /// <c>YYYY-MM-DD</c>.
        /// </summary>
        [JsonProperty("end_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_date")]
#endif
        public string EndDate { get; set; }

        /// <summary>
        /// Schedule at which the future payments will be charged.
        /// One of: <c>halfyearly</c>, <c>monthly</c>, <c>quarterly</c>, <c>weekly</c>, or
        /// <c>yearly</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_schedule")]
#endif
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Subscription name displayed to buyers in their bank app.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }

        /// <summary>
        /// Start date of the mandate, in <c>YYYY-MM-DD</c>.
        /// </summary>
        [JsonProperty("start_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start_date")]
#endif
        public string StartDate { get; set; }
    }
}
