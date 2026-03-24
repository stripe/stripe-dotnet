// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePhaseAddInvoiceItemPeriod : StripeEntity<SubscriptionSchedulePhaseAddInvoiceItemPeriod>
    {
        [JsonProperty("end")]
        [STJS.JsonPropertyName("end")]
        public SubscriptionSchedulePhaseAddInvoiceItemPeriodEnd End { get; set; }

        [JsonProperty("start")]
        [STJS.JsonPropertyName("start")]
        public SubscriptionSchedulePhaseAddInvoiceItemPeriodStart Start { get; set; }
    }
}
