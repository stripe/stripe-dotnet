// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// PayoutIntent represents an intent to send funds from a Financial Account to a payout
    /// method.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntent : StripeEntity<PayoutIntent>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the PayoutIntent.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The monetary amount to be sent.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the PayoutIntent was created. Represented as a RFC 3339 date &amp; time
        /// UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        public PayoutIntentFrom From { get; set; }

        /// <summary>
        /// Details about the latest payout associated with this PayoutIntent.
        /// </summary>
        [JsonProperty("latest_payout")]
        [STJS.JsonPropertyName("latest_payout")]
        public PayoutIntentLatestPayout LatestPayout { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Next action required for a PayoutIntent in the requires_action state. Populated when
        /// status is requires_action.
        /// </summary>
        [JsonProperty("next_action")]
        [STJS.JsonPropertyName("next_action")]
        public PayoutIntentNextAction NextAction { get; set; }

        /// <summary>
        /// Details about the OutboundPayment notification settings for recipient. Only applicable
        /// to OutboundPayment.
        /// </summary>
        [JsonProperty("recipient_notification")]
        [STJS.JsonPropertyName("recipient_notification")]
        public PayoutIntentRecipientNotification RecipientNotification { get; set; }

        /// <summary>
        /// Scheduling options for the payout. If this is nil, we assume immediate execution.
        /// </summary>
        [JsonProperty("schedule_options")]
        [STJS.JsonPropertyName("schedule_options")]
        public PayoutIntentScheduleOptions ScheduleOptions { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for the payout (for example, on a bank
        /// statement).
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Open Enum. Current status of the PayoutIntent: <c>pending</c>, <c>processing</c>,
        /// <c>posted</c>, <c>canceled</c>, <c>requires_action</c>.
        /// One of: <c>canceled</c>, <c>pending</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>requires_action</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Hash containing timestamps of when transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public PayoutIntentStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// To which payout method the payout is sent.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public PayoutIntentTo To { get; set; }
    }
}
