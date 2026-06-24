// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The monetary amount to be sent.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// An arbitrary string attached to the PayoutIntent. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount that funds are pulled from.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public PayoutIntentCreateFromOptions From { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the OutboundPayment notification settings for recipient. Only applicable
        /// to OutboundPayment.
        /// </summary>
        [JsonProperty("recipient_notification")]
        [STJS.JsonPropertyName("recipient_notification")]
        public PayoutIntentCreateRecipientNotificationOptions RecipientNotification { get; set; }

        /// <summary>
        /// Scheduling options for the payout. If this is nil, we assume immediate execution.
        /// </summary>
        [JsonProperty("schedule_options")]
        [STJS.JsonPropertyName("schedule_options")]
        public PayoutIntentCreateScheduleOptionsOptions ScheduleOptions { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for the payout (for example, on a bank
        /// statement).
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// To which payout method the payout is sent.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public PayoutIntentCreateToOptions To { get; set; }
    }
}
