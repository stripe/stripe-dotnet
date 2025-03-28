// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Adjustments represent Stripe-initiated credits or debits to a user balance. They might
    /// be used to amend balances due to technical or operational error.
    /// </summary>
    public class Adjustment : StripeEntity<Adjustment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// If applicable, contains information about the original flow linked to this Adjustment.
        /// </summary>
        [JsonProperty("adjusted_flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjusted_flow")]
#endif
        public AdjustmentAdjustedFlow AdjustedFlow { get; set; }

        /// <summary>
        /// The amount of the Adjustment.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as a RFC 3339 date &amp; time UTC
        /// value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Description of the Adjustment and what it was used for.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount that this adjustment is for.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A hosted transaction receipt URL that is provided when money movement is considered
        /// regulated under Stripe’s money transmission licenses.
        /// </summary>
        [JsonProperty("receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_url")]
#endif
        public string ReceiptUrl { get; set; }
    }
}
