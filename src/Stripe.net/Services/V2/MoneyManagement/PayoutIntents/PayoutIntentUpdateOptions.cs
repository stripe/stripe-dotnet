// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutIntentUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// An arbitrary string attached to the PayoutIntent. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Recipient notification settings for the PayoutIntent. Only applicable when the
        /// PayoutIntent creates an OutboundPayment.
        /// </summary>
        [JsonProperty("recipient_notification")]
        [STJS.JsonPropertyName("recipient_notification")]
        public PayoutIntentUpdateRecipientNotificationOptions RecipientNotification { get; set; }

        /// <summary>
        /// Scheduling options for the payout. If omitted, the payout is scheduled for immediate
        /// execution.
        /// </summary>
        [JsonProperty("schedule_options")]
        [STJS.JsonPropertyName("schedule_options")]
        public PayoutIntentUpdateScheduleOptionsOptions ScheduleOptions { get; set; }

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
        public PayoutIntentUpdateToOptions To { get; set; }
    }
}
