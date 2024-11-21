// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// You can store multiple cards on a customer in order to charge the customer later. You
    /// can also store multiple debit cards on a recipient in order to transfer to those cards
    /// later.
    ///
    /// Related guide: <a href="https://stripe.com/docs/sources/cards">Card payments with
    /// Sources</a>.
    /// </summary>
    public class Card : StripeEntity<Card>, IHasId, IHasMetadata, IHasObject, IExternalAccount, IPaymentSource
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
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The account this card belongs to. This attribute will not be in the card object if the
        /// card belongs to a customer or recipient instead. This property is only available for
        /// accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The account this card belongs to. This attribute will not be in the card object if the
        /// card belongs to a customer or recipient instead. This property is only available for
        /// accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif

        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonProperty("address_city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_city")]
#endif

        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [JsonProperty("address_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_country")]
#endif

        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonProperty("address_line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1")]
#endif

        public string AddressLine1 { get; set; }

        /// <summary>
        /// If <c>address_line1</c> was provided, results of the check: <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif

        public string AddressLine1Check { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonProperty("address_line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line2")]
#endif

        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonProperty("address_state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_state")]
#endif

        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("address_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_zip")]
#endif

        public string AddressZip { get; set; }

        /// <summary>
        /// If <c>address_zip</c> was provided, results of the check: <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_zip_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_zip_check")]
#endif

        public string AddressZipCheck { get; set; }

        /// <summary>
        /// A set of available payout methods for this card. Only values from this set should be
        /// passed as the <c>method</c> when creating a payout.
        /// One of: <c>instant</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("available_payout_methods")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available_payout_methods")]
#endif

        public List<string> AvailablePayoutMethods { get; set; }

        /// <summary>
        /// Card brand. Can be <c>American Express</c>, <c>Diners Club</c>, <c>Discover</c>,
        /// <c>Eftpos Australia</c>, <c>Girocard</c>, <c>JCB</c>, <c>MasterCard</c>,
        /// <c>UnionPay</c>, <c>Visa</c>, or <c>Unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif

        public string Brand { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif

        public string Country { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO code for
        /// currency</a> in lowercase. Must be a <a
        /// href="https://docs.stripe.com/currencies">supported currency</a>. Only applicable on
        /// accounts (not customers or recipients). The card can be used as a transfer destination
        /// for funds in this currency. This property is only available for accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The customer that this card belongs to. This attribute will not be in the card object if
        /// the card belongs to an account or recipient instead.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonInclude]
#endif

        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif

        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        /// <summary>
        /// If a CVC was provided, results of the check: <c>pass</c>, <c>fail</c>,
        /// <c>unavailable</c>, or <c>unchecked</c>. A result of unchecked indicates that CVC was
        /// provided but hasn't been checked yet. Checks are typically performed when attaching a
        /// card to a Customer object, or when creating a charge. For more details, see <a
        /// href="https://support.stripe.com/questions/check-if-a-card-is-valid-without-a-charge">Check
        /// if a card is valid without a charge</a>.
        /// </summary>
        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif

        public string CvcCheck { get; set; }

        /// <summary>
        /// Whether this card is the default external account for its currency. This property is
        /// only available for accounts where <a
        /// href="https://stripe.com/api/accounts/object#account_object-controller-requirement_collection">controller.requirement_collection</a>
        /// is <c>application</c>, which includes Custom accounts.
        /// </summary>
        [JsonProperty("default_for_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for_currency")]
#endif

        public bool? DefaultForCurrency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
#endif

        public bool? Deleted { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range. (For internal use
        /// only and not typically available in standard API requests.).
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dynamic_last4")]
#endif

        public string DynamicLast4 { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif

        public long ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif

        public long ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check
        /// whether two customers who’ve signed up with you are using the same card number, for
        /// example. For payment methods that tokenize card information (Apple Pay, Google Pay), the
        /// tokenized number might be provided instead of the underlying card number.
        ///
        /// <em>As of May 1, 2021, card fingerprint in India for Connect changed to allow two
        /// fingerprints for the same card---one for India and one for the rest of the world.</em>.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif

        public string Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif

        public string Funding { get; set; }

        /// <summary>
        /// Issuer identification number of the card. (For internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonProperty("iin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iin")]
#endif

        public string Iin { get; set; }

        /// <summary>
        /// The name of the card's issuing bank. (For internal use only and not typically available
        /// in standard API requests.).
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif

        public string Issuer { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif

        public string Last4 { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        [JsonProperty("networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("networks")]
#endif

        public CardNetworks Networks { get; set; }

        /// <summary>
        /// For external accounts that are cards, possible values are <c>new</c> and <c>errored</c>.
        /// If a payout fails, the status is set to <c>errored</c> and <a
        /// href="https://stripe.com/docs/payouts#payout-schedule">scheduled payouts</a> are stopped
        /// until account details are updated.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// If the card number is tokenized, this is the method that was used. Can be
        /// <c>android_pay</c> (includes Google Pay), <c>apple_pay</c>, <c>masterpass</c>,
        /// <c>visa_checkout</c>, or null.
        /// </summary>
        [JsonProperty("tokenization_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tokenization_method")]
#endif

        public string TokenizationMethod { get; set; }
    }
}
