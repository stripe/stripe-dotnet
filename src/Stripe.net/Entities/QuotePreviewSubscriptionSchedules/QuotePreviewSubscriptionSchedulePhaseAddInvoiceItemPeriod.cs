// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriod : StripeEntity<QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriod>
    {
        [JsonProperty("end")]
        [STJS.JsonPropertyName("end")]
        public QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriodEnd End { get; set; }

        [JsonProperty("start")]
        [STJS.JsonPropertyName("start")]
        public QuotePreviewSubscriptionSchedulePhaseAddInvoiceItemPeriodStart Start { get; set; }
    }
}
