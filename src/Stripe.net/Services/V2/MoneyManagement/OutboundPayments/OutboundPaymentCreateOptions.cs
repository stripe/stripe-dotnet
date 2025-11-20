// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The "presentment amount" to be sent to the recipient.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public OutboundPaymentCreateAmountOptions Amount { get; set; }

        /// <summary>
        /// Delivery options to be used to send the OutboundPayment.
        /// </summary>
        [JsonProperty("delivery_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_options")]
#endif
        public OutboundPaymentCreateDeliveryOptionsOptions DeliveryOptions { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundPayment. Often useful for displaying to
        /// users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// From which FinancialAccount and BalanceType to pull funds from.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public OutboundPaymentCreateFromOptions From { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The quote for this OutboundPayment. Only required for countries with regulatory mandates
        /// to display fee estimates before OutboundPayment creation.
        /// </summary>
        [JsonProperty("outbound_payment_quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payment_quote")]
#endif
        public string OutboundPaymentQuote { get; set; }

        /// <summary>
        /// Details about the notification settings for the OutboundPayment recipient.
        /// </summary>
        [JsonProperty("recipient_notification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient_notification")]
#endif
        public OutboundPaymentCreateRecipientNotificationOptions RecipientNotification { get; set; }

        /// <summary>
        /// To which payout method to send the OutboundPayment.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public OutboundPaymentCreateToOptions To { get; set; }
    }
}
