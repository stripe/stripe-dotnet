// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentQuoteCreateOptions : BaseOptions
    {
        /// <summary>
        /// The "presentment amount" to be sent to the recipient.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Method to be used to send the OutboundPayment.
        /// </summary>
        [JsonProperty("delivery_options")]
        [STJS.JsonPropertyName("delivery_options")]
        public OutboundPaymentQuoteCreateDeliveryOptionsOptions DeliveryOptions { get; set; }

        /// <summary>
        /// Request details about the sender of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public OutboundPaymentQuoteCreateFromOptions From { get; set; }

        /// <summary>
        /// Request details about the recipient of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public OutboundPaymentQuoteCreateToOptions To { get; set; }
    }
}
