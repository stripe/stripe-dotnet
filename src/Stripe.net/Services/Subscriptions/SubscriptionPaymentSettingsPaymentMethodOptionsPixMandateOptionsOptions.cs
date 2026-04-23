// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Amount to be charged for future payments. If not provided, defaults to 40000.
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
        /// Date when the mandate expires and no further payments will be charged, in
        /// <c>YYYY-MM-DD</c>. If not provided, the mandate will be active until canceled.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// Schedule at which the future payments will be charged. Defaults to the subscription
        /// servicing interval.
        /// One of: <c>halfyearly</c>, <c>monthly</c>, <c>quarterly</c>, <c>weekly</c>, or
        /// <c>yearly</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
        [STJS.JsonPropertyName("payment_schedule")]
        public string PaymentSchedule { get; set; }
    }
}
