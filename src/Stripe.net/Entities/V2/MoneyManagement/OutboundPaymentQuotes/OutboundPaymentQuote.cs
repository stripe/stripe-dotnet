// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// OutboundPaymentQuote represents a quote that provides fee and amount estimates for
    /// OutboundPayment.
    /// </summary>
    public class OutboundPaymentQuote : StripeEntity<OutboundPaymentQuote>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the OutboundPaymentQuote.
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
        /// The "presentment amount" for the OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public OutboundPaymentQuoteAmount Amount { get; set; }

        /// <summary>
        /// Time at which the OutboundPaymentQuote was created. Represented as a RFC 3339 date &amp;
        /// time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Delivery options to be used to send the OutboundPayment.
        /// </summary>
        [JsonProperty("delivery_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_options")]
#endif
        public OutboundPaymentQuoteDeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// The estimated fees for the OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("estimated_fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("estimated_fees")]
#endif
        public List<OutboundPaymentQuoteEstimatedFee> EstimatedFees { get; set; }

        /// <summary>
        /// Details about the sender of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public OutboundPaymentQuoteFrom From { get; set; }

        /// <summary>
        /// The underlying FXQuote details for the OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("fx_quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_quote")]
#endif
        public OutboundPaymentQuoteFxQuote FxQuote { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Details about the recipient of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public OutboundPaymentQuoteTo To { get; set; }
    }
}
