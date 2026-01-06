// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentTrackingDetails : StripeEntity<OutboundPaymentTrackingDetails>
    {
        /// <summary>
        /// Paper check tracking details.
        /// </summary>
        [JsonProperty("paper_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paper_check")]
#endif
        public OutboundPaymentTrackingDetailsPaperCheck PaperCheck { get; set; }
    }
}
