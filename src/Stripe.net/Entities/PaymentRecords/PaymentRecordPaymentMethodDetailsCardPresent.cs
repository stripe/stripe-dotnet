// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsCardPresent : StripeEntity<PaymentRecordPaymentMethodDetailsCardPresent>
    {
        /// <summary>
        /// The authorized amount.
        /// </summary>
        [JsonProperty("amount_authorized")]
        [STJS.JsonPropertyName("amount_authorized")]
        public long? AmountAuthorized { get; set; }

        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/card-product-codes">product code</a> that
        /// identifies the specific program or product associated with a card.
        /// </summary>
        [JsonProperty("brand_product")]
        [STJS.JsonPropertyName("brand_product")]
        public string BrandProduct { get; set; }

        /// <summary>
        /// When using manual capture, a future timestamp after which the charge will be
        /// automatically refunded if uncaptured.
        /// </summary>
        [JsonProperty("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("capture_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The cardholder name as read from the card, in <a
        /// href="https://en.wikipedia.org/wiki/ISO/IEC_7813">ISO 7813</a> format. May include
        /// alphanumeric characters, special characters and first/last name separator (<c>/</c>). In
        /// some cases, the cardholder name may not be available depending on how the issuer has
        /// configured the card. Cardholder name is typically not available on swipe or contactless
        /// payments, such as those made with Apple Pay and Google Pay.
        /// </summary>
        [JsonProperty("cardholder_name")]
        [STJS.JsonPropertyName("cardholder_name")]
        public string CardholderName { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range. (For internal use
        /// only and not typically available in standard API requests.).
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Authorization response cryptogram.
        /// </summary>
        [JsonProperty("emv_auth_data")]
        [STJS.JsonPropertyName("emv_auth_data")]
        public string EmvAuthData { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
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
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
        [STJS.JsonPropertyName("generated_card")]
        public string GeneratedCard { get; set; }

        /// <summary>
        /// Issuer identification number of the card. (For internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonProperty("iin")]
        [STJS.JsonPropertyName("iin")]
        public string Iin { get; set; }

        /// <summary>
        /// Whether this <a href="https://docs.stripe.com/api/payment_intents">PaymentIntent</a> is
        /// eligible for incremental authorizations. Request support using <a
        /// href="https://docs.stripe.com/api/payment_intents/create#create_payment_intent-payment_method_options-card_present-request_incremental_authorization_support">request_incremental_authorization_support</a>.
        /// </summary>
        [JsonProperty("incremental_authorization_supported")]
        [STJS.JsonPropertyName("incremental_authorization_supported")]
        public bool IncrementalAuthorizationSupported { get; set; }

        /// <summary>
        /// The name of the card's issuing bank. (For internal use only and not typically available
        /// in standard API requests.).
        /// </summary>
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/locations">location</a> that
        /// this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// This is used by the financial networks to identify a transaction. Visa calls this the
        /// Transaction ID, Mastercard calls this the Trace ID, and American Express calls this the
        /// Acquirer Reference Data. This value will be present if it is returned by the financial
        /// network in the authorization response, and null otherwise.
        /// </summary>
        [JsonProperty("network_transaction_id")]
        [STJS.JsonPropertyName("network_transaction_id")]
        public string NetworkTransactionId { get; set; }

        /// <summary>
        /// Details about payments collected offline.
        /// </summary>
        [JsonProperty("offline")]
        [STJS.JsonPropertyName("offline")]
        public PaymentRecordPaymentMethodDetailsCardPresentOffline Offline { get; set; }

        /// <summary>
        /// Defines whether the authorized amount can be over-captured or not.
        /// </summary>
        [JsonProperty("overcapture_supported")]
        [STJS.JsonPropertyName("overcapture_supported")]
        public bool OvercaptureSupported { get; set; }

        /// <summary>
        /// The languages that the issuing bank recommends using for localizing any customer-facing
        /// text, as read from the card. Referenced from EMV tag 5F2D, data encoded on the card's
        /// chip.
        /// </summary>
        [JsonProperty("preferred_locales")]
        [STJS.JsonPropertyName("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// How card details were read in this transaction.
        /// One of: <c>contact_emv</c>, <c>contactless_emv</c>, <c>contactless_magstripe_mode</c>,
        /// <c>magnetic_stripe_fallback</c>, or <c>magnetic_stripe_track2</c>.
        /// </summary>
        [JsonProperty("read_method")]
        [STJS.JsonPropertyName("read_method")]
        public string ReadMethod { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/readers">reader</a> this
        /// transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
        [STJS.JsonPropertyName("reader")]
        public string Reader { get; set; }

        /// <summary>
        /// A collection of fields required to be displayed on receipts. Only required for EMV
        /// transactions.
        /// </summary>
        [JsonProperty("receipt")]
        [STJS.JsonPropertyName("receipt")]
        public PaymentRecordPaymentMethodDetailsCardPresentReceipt Receipt { get; set; }

        [JsonProperty("wallet")]
        [STJS.JsonPropertyName("wallet")]
        public PaymentRecordPaymentMethodDetailsCardPresentWallet Wallet { get; set; }

        /// <summary>
        /// Whether the PaymentIntent can be reauthorized or not.
        /// </summary>
        [JsonProperty("reauthorization")]
        [STJS.JsonPropertyName("reauthorization")]
        public PaymentRecordPaymentMethodDetailsCardPresentReauthorization Reauthorization { get; set; }

        /// <summary>
        /// The time at which the associated PaymentIntent will transition to a terminal state if it
        /// is not reauthorized.
        /// </summary>
        [JsonProperty("reauthorize_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("reauthorize_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ReauthorizeBefore { get; set; }
    }
}
