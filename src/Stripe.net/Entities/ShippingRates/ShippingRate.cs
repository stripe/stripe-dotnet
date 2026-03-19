// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Shipping rates describe the price of shipping presented to your customers and applied to
    /// a purchase. For more information, see <a
    /// href="https://docs.stripe.com/payments/during-payment/charge-shipping">Charge for
    /// shipping</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ShippingRate : StripeEntity<ShippingRate>, IHasId, IHasMetadata, IHasObject
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
        /// Whether the shipping rate can be used for new purchases. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The estimated range for how long shipping will take, meant to be displayable to the
        /// customer. This will appear on CheckoutSessions.
        /// </summary>
        [JsonProperty("delivery_estimate")]
        [STJS.JsonPropertyName("delivery_estimate")]
        public ShippingRateDeliveryEstimate DeliveryEstimate { get; set; }

        /// <summary>
        /// The name of the shipping rate, meant to be displayable to the customer. This will appear
        /// on CheckoutSessions.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("fixed_amount")]
        [STJS.JsonPropertyName("fixed_amount")]
        public ShippingRateFixedAmount FixedAmount { get; set; }

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
        /// Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One
        /// of <c>inclusive</c>, <c>exclusive</c>, or <c>unspecified</c>.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        #region Expandable TaxCode

        /// <summary>
        /// (ID of the TaxCode)
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID. The Shipping tax
        /// code is <c>txcd_92010001</c>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TaxCodeId
        {
            get => this.InternalTaxCode?.Id;
            set => this.InternalTaxCode = SetExpandableFieldId(value, this.InternalTaxCode);
        }

        /// <summary>
        /// (Expanded)
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID. The Shipping tax
        /// code is <c>txcd_92010001</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public TaxCode TaxCode
        {
            get => this.InternalTaxCode?.ExpandedObject;
            set => this.InternalTaxCode = SetExpandableFieldObject(value, this.InternalTaxCode);
        }

        [JsonProperty("tax_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxCode>))]
        [STJS.JsonPropertyName("tax_code")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TaxCode>))]
        internal ExpandableField<TaxCode> InternalTaxCode { get; set; }
        #endregion

        /// <summary>
        /// The type of calculation to use on the shipping rate.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
