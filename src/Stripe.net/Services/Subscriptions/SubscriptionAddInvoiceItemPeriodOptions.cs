// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionAddInvoiceItemPeriodOptions : INestedOptions
    {
        /// <summary>
        /// End of the invoice item period.
        /// </summary>
        [JsonProperty("end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end")]
#endif
        public SubscriptionAddInvoiceItemPeriodEndOptions End { get; set; }

        /// <summary>
        /// Start of the invoice item period.
        /// </summary>
        [JsonProperty("start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start")]
#endif
        public SubscriptionAddInvoiceItemPeriodStartOptions Start { get; set; }
    }
}
