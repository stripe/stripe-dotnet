// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsPixMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Amount to be charged for future payments. Required when <c>amount_type=fixed</c>. If not
        /// provided for <c>amount_type=maximum</c>, defaults to 40000.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Determines if the amount includes the IOF tax. Defaults to <c>never</c>.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
        [STJS.JsonPropertyName("amount_includes_iof")]
        public string AmountIncludesIof { get; set; }

        /// <summary>
        /// Type of amount. Defaults to <c>maximum</c>.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
        [STJS.JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Only <c>brl</c> is supported currently.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Date when the mandate expires and no further payments will be charged, in
        /// <c>YYYY-MM-DD</c>. If not provided, the mandate will be active until canceled. If
        /// provided, end date should be after start date.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// Schedule at which the future payments will be charged. Defaults to <c>weekly</c>.
        /// One of: <c>halfyearly</c>, <c>monthly</c>, <c>quarterly</c>, <c>weekly</c>, or
        /// <c>yearly</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
        [STJS.JsonPropertyName("payment_schedule")]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Subscription name displayed to buyers in their bank app. Defaults to the displayable
        /// business name.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Start date of the mandate, in <c>YYYY-MM-DD</c>. Start date should be at least 3 days in
        /// the future. Defaults to 3 days after the current date.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
