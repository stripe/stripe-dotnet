// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An InboundFunding represents an other-to-me pull movement into a FinancialAccount.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundFunding : StripeEntity<InboundFunding>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
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
        /// The amount of the InboundFunding.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An arbitrary string attached to the InboundFunding.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The source of the funds.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public InboundFundingFrom From { get; set; }

        /// <summary>
        /// The check lifecycle history.
        /// </summary>
        [JsonProperty("history")]
        [STJS.JsonPropertyName("history")]
        public List<InboundFundingHistory> History { get; set; }

        /// <summary>
        /// Whether the InboundFunding exists in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The current status of the InboundFunding.
        /// One of: <c>failed</c>, <c>processing</c>, <c>queued</c>, <c>returned</c>, or
        /// <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The destination for the funds.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public InboundFundingTo To { get; set; }
    }
}
