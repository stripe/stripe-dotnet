// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentStatusDetails : StripeEntity<OutboundPaymentStatusDetails>
    {
        /// <summary>
        /// The <c>failed</c> status reason.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public OutboundPaymentStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// The <c>returned</c> status reason.
        /// </summary>
        [JsonProperty("returned")]
        [STJS.JsonPropertyName("returned")]
        public OutboundPaymentStatusDetailsReturned Returned { get; set; }
    }
}
