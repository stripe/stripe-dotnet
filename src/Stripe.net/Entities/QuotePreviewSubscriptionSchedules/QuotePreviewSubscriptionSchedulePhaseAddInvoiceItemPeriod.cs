// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriod : StripeEntity<QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriod>
    {
        [JsonProperty("end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end")]
#endif
        public QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriodEnd End { get; set; }

        [JsonProperty("start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("start")]
#endif
        public QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriodStart Start { get; set; }
    }
}
