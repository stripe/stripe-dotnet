// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Amount to be charged for future payments. If not provided, defaults to 40000.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Determines if the amount includes the IOF tax. Defaults to <c>never</c>.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_includes_iof")]
#endif
        public string AmountIncludesIof { get; set; }

        /// <summary>
        /// Date when the mandate expires and no further payments will be charged, in
        /// <c>YYYY-MM-DD</c>. If not provided, the mandate will be active until canceled.
        /// </summary>
        [JsonProperty("end_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_date")]
#endif
        public string EndDate { get; set; }

        /// <summary>
        /// Schedule at which the future payments will be charged. Defaults to <c>weekly</c>.
        /// One of: <c>halfyearly</c>, <c>monthly</c>, <c>quarterly</c>, <c>weekly</c>, or
        /// <c>yearly</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_schedule")]
#endif
        public string PaymentSchedule { get; set; }
    }
}
