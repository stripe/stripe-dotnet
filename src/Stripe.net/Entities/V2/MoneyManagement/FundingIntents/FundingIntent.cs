// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A FundingIntent represents the lifecycle of adding funds to a FinancialAccount.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntent : StripeEntity<FundingIntent>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the FundingIntent.
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
        /// The amount to add to the destination.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Whether you can cancel the FundingIntent.
        /// </summary>
        [JsonProperty("cancelable")]
        [STJS.JsonPropertyName("cancelable")]
        public bool Cancelable { get; set; }

        /// <summary>
        /// Details for a check FundingIntent.
        /// </summary>
        [JsonProperty("check")]
        [STJS.JsonPropertyName("check")]
        public FundingIntentCheck Check { get; set; }

        /// <summary>
        /// How the FundingIntent is confirmed after validation.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("confirmation_method")]
        [STJS.JsonPropertyName("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        /// <summary>
        /// Time at which the FundingIntent was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An arbitrary string attached to the FundingIntent.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Details about the latest underlying money movement attempt.
        /// </summary>
        [JsonProperty("latest_attempt")]
        [STJS.JsonPropertyName("latest_attempt")]
        public FundingIntentLatestAttempt LatestAttempt { get; set; }

        /// <summary>
        /// Whether the FundingIntent exists in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs attached to the FundingIntent.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The action required to continue processing the FundingIntent.
        /// </summary>
        [JsonProperty("next_action")]
        [STJS.JsonPropertyName("next_action")]
        public FundingIntentNextAction NextAction { get; set; }

        /// <summary>
        /// The information to review before confirming the FundingIntent.
        /// </summary>
        [JsonProperty("next_confirmation")]
        [STJS.JsonPropertyName("next_confirmation")]
        public FundingIntentNextConfirmation NextConfirmation { get; set; }

        /// <summary>
        /// Controls when the funds become available after processing.
        /// </summary>
        [JsonProperty("settlement_timing")]
        [STJS.JsonPropertyName("settlement_timing")]
        public FundingIntentSettlementTiming SettlementTiming { get; set; }

        /// <summary>
        /// The current status of the FundingIntent.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_action</c>,
        /// <c>requires_confirmation</c>, <c>succeeded</c>, or <c>validating</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current status.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public FundingIntentStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Timestamps for the FundingIntent's status transitions.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public FundingIntentStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The destination for the funds.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public FundingIntentTo To { get; set; }

        /// <summary>
        /// The type of FundingIntent.
        /// One of: <c>check</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
