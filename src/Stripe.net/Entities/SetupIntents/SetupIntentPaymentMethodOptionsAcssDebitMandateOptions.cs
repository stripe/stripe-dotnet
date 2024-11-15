// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsAcssDebitMandateOptions : StripeEntity<SetupIntentPaymentMethodOptionsAcssDebitMandateOptions>
    {
        /// <summary>
        /// A URL for custom mandate text.
        /// </summary>
        [JsonProperty("custom_mandate_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_mandate_url")]
#endif

        public string CustomMandateUrl { get; set; }

        /// <summary>
        /// List of Stripe products where this mandate can be selected automatically.
        /// One of: <c>invoice</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("default_for")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for")]
#endif

        public List<string> DefaultFor { get; set; }

        /// <summary>
        /// Description of the interval. Only required if the 'payment_schedule' parameter is
        /// 'interval' or 'combined'.
        /// </summary>
        [JsonProperty("interval_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_description")]
#endif

        public string IntervalDescription { get; set; }

        /// <summary>
        /// Payment schedule for the mandate.
        /// One of: <c>combined</c>, <c>interval</c>, or <c>sporadic</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_schedule")]
#endif

        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_type")]
#endif

        public string TransactionType { get; set; }
    }
}
