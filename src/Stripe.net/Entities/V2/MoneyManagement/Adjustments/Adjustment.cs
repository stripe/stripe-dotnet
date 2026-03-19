// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Adjustments represent Stripe-initiated credits or debits to a user balance. They might
    /// be used to amend balances due to technical or operational error.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Adjustment : StripeEntity<Adjustment>, IHasId, IHasObject
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
        /// If applicable, contains information about the original flow linked to this Adjustment.
        /// </summary>
        [JsonProperty("adjusted_flow")]
        [STJS.JsonPropertyName("adjusted_flow")]
        public AdjustmentAdjustedFlow AdjustedFlow { get; set; }

        /// <summary>
        /// The amount of the Adjustment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Description of the Adjustment and what it was used for.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount that this adjustment is for.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A link to the Stripe-hosted receipt that is provided when money movement is considered
        /// regulated under Stripe’s money transmission licenses. The receipt link remains active
        /// for 60 days from the Adjustment creation date. After this period, the link will expire
        /// and the receipt url value will be null.
        /// </summary>
        [JsonProperty("receipt_url")]
        [STJS.JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }
    }
}
