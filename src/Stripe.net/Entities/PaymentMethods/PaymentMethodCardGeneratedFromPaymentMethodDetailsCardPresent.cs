// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent : StripeEntity<PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresent>
    {
        /// <summary>
        /// The authorized amount.
        /// </summary>
        [JsonProperty("amount_authorized")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_authorized")]
#endif
        public long? AmountAuthorized { get; set; }

        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif
        public string Brand { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/card-product-codes">product code</a> that
        /// identifies the specific program or product associated with a card.
        /// </summary>
        [JsonProperty("brand_product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand_product")]
#endif
        public string BrandProduct { get; set; }

        /// <summary>
        /// When using manual capture, a future timestamp after which the charge will be
        /// automatically refunded if uncaptured.
        /// </summary>
        [JsonProperty("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder_name")]
#endif
        public string CardholderName { get; set; }

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
        /// A high-level description of the type of cards issued in this range. (For internal use
        /// only and not typically available in standard API requests.).
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Authorization response cryptogram.
        /// </summary>
        [JsonProperty("emv_auth_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("emv_auth_data")]
#endif
        public string EmvAuthData { get; set; }

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
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("generated_card")]
#endif
        public string GeneratedCard { get; set; }

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
        /// Whether this <a href="https://stripe.com/docs/api/payment_intents">PaymentIntent</a> is
        /// eligible for incremental authorizations. Request support using <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-payment_method_options-card_present-request_incremental_authorization_support">request_incremental_authorization_support</a>.
        /// </summary>
        [JsonProperty("incremental_authorization_supported")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("incremental_authorization_supported")]
#endif
        public bool IncrementalAuthorizationSupported { get; set; }

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
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// This is used by the financial networks to identify a transaction. Visa calls this the
        /// Transaction ID, Mastercard calls this the Trace ID, and American Express calls this the
        /// Acquirer Reference Data. The first three digits of the Trace ID is the Financial Network
        /// Code, the next 6 digits is the Banknet Reference Number, and the last 4 digits represent
        /// the date (MM/DD). This field will be available for successful Visa, Mastercard, or
        /// American Express transactions and always null for other card brands.
        /// </summary>
        [JsonProperty("network_transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_transaction_id")]
#endif
        public string NetworkTransactionId { get; set; }

        /// <summary>
        /// Details about payments collected offline.
        /// </summary>
        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif
        public PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentOffline Offline { get; set; }

        /// <summary>
        /// Defines whether the authorized amount can be over-captured or not.
        /// </summary>
        [JsonProperty("overcapture_supported")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("overcapture_supported")]
#endif
        public bool OvercaptureSupported { get; set; }

        /// <summary>
        /// EMV tag 5F2D. Preferred languages specified by the integrated circuit chip.
        /// </summary>
        [JsonProperty("preferred_locales")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_locales")]
#endif
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// How card details were read in this transaction.
        /// One of: <c>contact_emv</c>, <c>contactless_emv</c>, <c>contactless_magstripe_mode</c>,
        /// <c>magnetic_stripe_fallback</c>, or <c>magnetic_stripe_track2</c>.
        /// </summary>
        [JsonProperty("read_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("read_method")]
#endif
        public string ReadMethod { get; set; }

        /// <summary>
        /// A collection of fields required to be displayed on receipts. Only required for EMV
        /// transactions.
        /// </summary>
        [JsonProperty("receipt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt")]
#endif
        public PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentReceipt Receipt { get; set; }

        [JsonProperty("wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet")]
#endif
        public PaymentMethodCardGeneratedFromPaymentMethodDetailsCardPresentWallet Wallet { get; set; }
    }
}
