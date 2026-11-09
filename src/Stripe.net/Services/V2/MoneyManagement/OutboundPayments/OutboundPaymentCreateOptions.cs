// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundPaymentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The requested amount and currency for the OutboundPayment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundPayment. Often useful for displaying to
        /// users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// From which FinancialAccount and BalanceType to pull funds from.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public OutboundPaymentCreateFromOptions From { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the notification settings for the OutboundPayment recipient.
        /// </summary>
        [JsonProperty("recipient_notification")]
        [STJS.JsonPropertyName("recipient_notification")]
        public OutboundPaymentCreateRecipientNotificationOptions RecipientNotification { get; set; }

        /// <summary>
        /// The ID of the RecipientVerification for this OutboundPayment. Required where
        /// recipient-name verification is mandated before creating an OutboundPayment.
        /// </summary>
        [JsonProperty("recipient_verification")]
        [STJS.JsonPropertyName("recipient_verification")]
        public string RecipientVerification { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for an OutboundPayment (for example,
        /// on a bank statement). Must be between 3 and 22 characters long for most destinations
        /// (500 for FinancialAccount destinations), and not contain profanity.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// To which payout method to send the OutboundPayment.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public OutboundPaymentCreateToOptions To { get; set; }
    }
}
