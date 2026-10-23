// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FundingIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount to add to the destination.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Details for a check FundingIntent.
        /// </summary>
        [JsonProperty("check")]
        [STJS.JsonPropertyName("check")]
        public FundingIntentCreateCheckOptions Check { get; set; }

        /// <summary>
        /// How to confirm the FundingIntent after validation.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("confirmation_method")]
        [STJS.JsonPropertyName("confirmation_method")]
        public string ConfirmationMethod { get; set; }

        /// <summary>
        /// An arbitrary string to attach to the FundingIntent.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of key-value pairs to attach to the FundingIntent.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Controls when the funds become available after processing.
        /// </summary>
        [JsonProperty("settlement_timing")]
        [STJS.JsonPropertyName("settlement_timing")]
        public FundingIntentCreateSettlementTimingOptions SettlementTiming { get; set; }

        /// <summary>
        /// The destination for the funds.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public FundingIntentCreateToOptions To { get; set; }

        /// <summary>
        /// The type of FundingIntent to create.
        /// One of: <c>check</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
