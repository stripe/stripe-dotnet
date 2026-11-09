// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetailsBankAccount : StripeEntity<OutboundPaymentTrackingDetailsBankAccount>
    {
        /// <summary>
        /// A unique identifier that can be used to track this OutboundPayment with the recipient
        /// bank. Banks might call this a “reference number” or something similar.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
