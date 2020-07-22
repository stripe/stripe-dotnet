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

        /// <summary>
        /// Properties specific to AU BECS Debit PaymentMethod.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentMethodAuBecsDebit AuBecsDebit { get; set; }

        /// <summary>
        /// Properties specific to BACS Debit PaymentMethod.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public PaymentMethodBacsDebit BacsDebit { get; set; }

        /// <summary>
        /// Properties specific to Bancontact PaymentMethod.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentMethodBancontact Bancontact { get; set; }

        /// <summary>
        /// Billing details associated with this PaymentMethod.
        /// </summary>
        [JsonProperty("billing_details")]
        public BillingDetails BillingDetails { get; set; }

        /// <summary>
        /// Properties specific to Card PaymentMethod.
        /// </summary>
        [JsonProperty("card")]
        public PaymentMethodCard Card { get; set; }

        /// <summary>
        /// Properties specific to Card Present PaymentMethod.
        /// </summary>
        [JsonProperty("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        #region Expandable Customer

        /// <summary>
        /// ID of the customer this PaymentMethod is for if any.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// Customer this PaymentMethod is for (if it was expanded).
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

        /// <summary>
        /// Properties specific to Eps PaymentMethod.
        /// </summary>
        [JsonProperty("eps")]
        public PaymentMethodEps Eps { get; set; }

        /// <summary>
        /// Properties specific to FPX PaymentMethod.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentMethodFpx Fpx { get; set; }

        /// <summary>
        /// Properties specific to Giropay PaymentMethod.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentMethodGiropay Giropay { get; set; }

        /// <summary>
        /// Properties specific to iDEAL PaymentMethod.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentMethodIdeal Ideal { get; set; }

        /// <summary>
        /// Properties specific to Interac present PaymentMethod.
        /// </summary>
        [JsonProperty("interac_present")]
        public PaymentMethodInteracPresent InteracPresent { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Properties specific to P24 PaymentMethod.
        /// </summary>
        [JsonProperty("p24")]
        public PaymentMethodP24 P24 { get; set; }

        /// <summary>
        /// Properties specific to SEPA Debit PaymentMethod.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// The type of PaymentMethod.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
