// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentQuoteCreateOptions : BaseOptions
    {
        /// <summary>
        /// The "presentment amount" to be sent to the recipient.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public OutboundPaymentQuoteCreateAmountOptions Amount { get; set; }

        /// <summary>
        /// Method to be used to send the OutboundPayment.
        /// </summary>
        [JsonProperty("delivery_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_options")]
#endif
        public OutboundPaymentQuoteCreateDeliveryOptionsOptions DeliveryOptions { get; set; }

        /// <summary>
        /// Request details about the sender of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public OutboundPaymentQuoteCreateFromOptions From { get; set; }

        /// <summary>
        /// Request details about the recipient of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public OutboundPaymentQuoteCreateToOptions To { get; set; }
    }
}
