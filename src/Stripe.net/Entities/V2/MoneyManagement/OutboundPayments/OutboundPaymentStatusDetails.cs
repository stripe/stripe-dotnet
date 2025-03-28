// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentStatusDetails : StripeEntity<OutboundPaymentStatusDetails>
    {
        /// <summary>
        /// The <c>failed</c> status reason.
        /// </summary>
        [JsonProperty("failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed")]
#endif
        public OutboundPaymentStatusDetailsFailed Failed { get; set; }

        /// <summary>
        /// The <c>returned</c> status reason.
        /// </summary>
        [JsonProperty("returned")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned")]
#endif
        public OutboundPaymentStatusDetailsReturned Returned { get; set; }
    }
}
