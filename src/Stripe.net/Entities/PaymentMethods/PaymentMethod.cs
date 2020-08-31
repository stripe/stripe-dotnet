namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethod : StripeEntity<PaymentMethod>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("alipay")]
        public PaymentMethodAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentMethodBancontact Bancontact { get; set; }

        [JsonProperty("billing_details")]
        public PaymentMethodBillingDetails BillingDetails { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCard Card { get; set; }

        [JsonProperty("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("eps")]
        public PaymentMethodEps Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentMethodGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresent InteracPresent { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("p24")]
        public PaymentMethodP24 P24 { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>alipay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>,
        /// <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>ideal</c>,
        /// <c>p24</c>, or <c>sepa_debit</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
