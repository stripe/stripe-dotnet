// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// OutboundPaymentQuote represents a quote that provides fee and amount estimates for
    /// OutboundPayment.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuote : StripeEntity<OutboundPaymentQuote>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the OutboundPaymentQuote.
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
        /// The "presentment amount" for the OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the OutboundPaymentQuote was created. Represented as a RFC 3339 date &amp;
        /// time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Delivery options to be used to send the OutboundPayment.
        /// </summary>
        [JsonProperty("delivery_options")]
        [STJS.JsonPropertyName("delivery_options")]
        public OutboundPaymentQuoteDeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// The estimated fees for the OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("estimated_fees")]
        [STJS.JsonPropertyName("estimated_fees")]
        public List<OutboundPaymentQuoteEstimatedFee> EstimatedFees { get; set; }

        /// <summary>
        /// Details about the sender of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public OutboundPaymentQuoteFrom From { get; set; }

        /// <summary>
        /// The underlying FXQuote details for the OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("fx_quote")]
        [STJS.JsonPropertyName("fx_quote")]
        public OutboundPaymentQuoteFxQuote FxQuote { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Details about the recipient of an OutboundPaymentQuote.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public OutboundPaymentQuoteTo To { get; set; }
    }
}
