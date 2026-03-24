// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetails : StripeEntity<OutboundPaymentTrackingDetails>
    {
        /// <summary>
        /// Paper check tracking details.
        /// </summary>
        [JsonProperty("paper_check")]
        [STJS.JsonPropertyName("paper_check")]
        public OutboundPaymentTrackingDetailsPaperCheck PaperCheck { get; set; }
    }
}
