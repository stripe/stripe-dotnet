// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetailsCard : StripeEntity<OutboundPaymentTrackingDetailsCard>
    {
        /// <summary>
        /// A unique identifier that can be used to track this OutboundPayment with the recipient
        /// card.
        /// </summary>
        [JsonProperty("retrieval_reference")]
        [STJS.JsonPropertyName("retrieval_reference")]
        public string RetrievalReference { get; set; }
    }
}
