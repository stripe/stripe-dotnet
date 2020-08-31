namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Card : StripeEntity<Card>, IHasId, IHasMetadata, IHasObject, IExternalAccount, IPaymentSource
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

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The account this card belongs to. This attribute will not be in the card object if the
        /// card belongs to a customer or recipient instead.
        /// </summary>
        [JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The account this card belongs to. This attribute will not be in the card object if the
        /// card belongs to a customer or recipient instead.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// If <c>address_line1</c> was provided, results of the check: <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// If <c>address_zip</c> was provided, results of the check: <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        /// <summary>
        /// A set of available payout methods for this card. Will be either <c>["standard"]</c> or
        /// <c>["standard", "instant"]</c>. Only values from this set should be passed as the
        /// <c>method</c> when creating a transfer.
        /// </summary>
        [JsonProperty("available_payout_methods")]
        public List<string> AvailablePayoutMethods { get; set; }

        /// <summary>
        /// Card brand. Can be <c>American Express</c>, <c>Diners Club</c>, <c>Discover</c>,
        /// <c>JCB</c>, <c>MasterCard</c>, <c>UnionPay</c>, <c>Visa</c>, or <c>Unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The customer that this card belongs to. This attribute will not be in the card object if
        /// the card belongs to an account or recipient instead.
        /// </summary>
        [JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The customer that this card belongs to. This attribute will not be in the card object if
        /// the card belongs to an account or recipient instead.
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

        /// <summary>
        /// If a CVC was provided, results of the check: <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        /// <summary>
        /// Whether this card is the default external account for its currency.
        /// </summary>
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Card description. (Only for internal use only and not typically available in standard
        /// API requests.).
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check
        /// whether two customers who’ve signed up with you are using the same card number,for
        /// example. For payment methods that tokenize card information (Apple Pay, Google Pay), the
        /// tokenized number might be provided instead of the underlying card number.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// Issuer identification number of the card. (Only for internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonProperty("iin")]
        public string Iin { get; set; }

        /// <summary>
        /// Issuer bank name of the card. (Only for internal use only and not typically available in
        /// standard API requests.).
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// If the card number is tokenized, this is the method that was used. Can be
        /// <c>android_pay</c> (includes Google Pay), <c>apple_pay</c>, <c>masterpass</c>,
        /// <c>visa_checkout</c>, or null.
        /// </summary>
        [JsonProperty("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
