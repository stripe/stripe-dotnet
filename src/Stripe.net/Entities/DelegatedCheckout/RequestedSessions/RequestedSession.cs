// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A requested session is a session that has been requested by a customer.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSession : StripeEntity<RequestedSession>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Affiliate attribution data associated with this requested session.
        /// </summary>
        [JsonProperty("affiliate_attributions")]
        [STJS.JsonPropertyName("affiliate_attributions")]
        public List<RequestedSessionAffiliateAttribution> AffiliateAttributions { get; set; }

        /// <summary>
        /// The subtotal amount of the requested session.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        [STJS.JsonPropertyName("amount_subtotal")]
        public long? AmountSubtotal { get; set; }

        /// <summary>
        /// The total amount of the requested session.
        /// </summary>
        [JsonProperty("amount_total")]
        [STJS.JsonPropertyName("amount_total")]
        public long? AmountTotal { get; set; }

        /// <summary>
        /// The buyer consent options for this requested session, including marketing preferences.
        /// </summary>
        [JsonProperty("buyer_consents")]
        [STJS.JsonPropertyName("buyer_consents")]
        public RequestedSessionBuyerConsents BuyerConsents { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The customer for this requested session.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Time at which the requested session expires. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The details of the fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_details")]
        [STJS.JsonPropertyName("fulfillment_details")]
        public RequestedSessionFulfillmentDetails FulfillmentDetails { get; set; }

        /// <summary>
        /// The line items to be purchased.
        /// </summary>
        [JsonProperty("line_item_details")]
        [STJS.JsonPropertyName("line_item_details")]
        public List<RequestedSessionLineItemDetail> LineItemDetails { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The details of the order.
        /// </summary>
        [JsonProperty("order_details")]
        [STJS.JsonPropertyName("order_details")]
        public RequestedSessionOrderDetails OrderDetails { get; set; }

        /// <summary>
        /// The payment method used for the requested session.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The payment method options for this requested session.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public RequestedSessionPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The preview of the payment method to be created when the requested session is confirmed.
        /// </summary>
        [JsonProperty("payment_method_preview")]
        [STJS.JsonPropertyName("payment_method_preview")]
        public RequestedSessionPaymentMethodPreview PaymentMethodPreview { get; set; }

        /// <summary>
        /// The risk details of the requested session.
        /// </summary>
        [JsonProperty("risk_details")]
        [STJS.JsonPropertyName("risk_details")]
        public RequestedSessionRiskDetails RiskDetails { get; set; }

        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public RequestedSessionSellerDetails SellerDetails { get; set; }

        /// <summary>
        /// Whether or not the payment method should be saved for future use.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// The metadata shared with the seller.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata { get; set; }

        #region Expandable SharedPaymentIssuedToken

        /// <summary>
        /// (ID of the SharedPayment.IssuedToken)
        /// The SPT used for payment.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SharedPaymentIssuedTokenId
        {
            get => this.InternalSharedPaymentIssuedToken?.Id;
            set => this.InternalSharedPaymentIssuedToken = SetExpandableFieldId(value, this.InternalSharedPaymentIssuedToken);
        }

        /// <summary>
        /// (Expanded)
        /// The SPT used for payment.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public SharedPayment.IssuedToken SharedPaymentIssuedToken
        {
            get => this.InternalSharedPaymentIssuedToken?.ExpandedObject;
            set => this.InternalSharedPaymentIssuedToken = SetExpandableFieldObject(value, this.InternalSharedPaymentIssuedToken);
        }

        [JsonProperty("shared_payment_issued_token")]
        [JsonConverter(typeof(ExpandableFieldConverter<SharedPayment.IssuedToken>))]
        [STJS.JsonPropertyName("shared_payment_issued_token")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<SharedPayment.IssuedToken>))]
        internal ExpandableField<SharedPayment.IssuedToken> InternalSharedPaymentIssuedToken { get; set; }
        #endregion

        /// <summary>
        /// The status of the requested session.
        /// One of: <c>completed</c>, <c>expired</c>, <c>open</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("total_details")]
        [STJS.JsonPropertyName("total_details")]
        public RequestedSessionTotalDetails TotalDetails { get; set; }

        /// <summary>
        /// Time at which the object was last updated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("updated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime UpdatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
