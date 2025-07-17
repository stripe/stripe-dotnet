// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsCard : StripeEntity<ChargePaymentMethodDetailsCard>
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
        /// The latest amount intended to be authorized by this charge.
        /// </summary>
        [JsonProperty("amount_requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_requested")]
#endif
        public long? AmountRequested { get; set; }

        /// <summary>
        /// Authorization code on the charge.
        /// </summary>
        [JsonProperty("authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_code")]
#endif
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif
        public string Brand { get; set; }

        /// <summary>
        /// When using manual capture, a future timestamp at which the charge will be automatically
        /// refunded if uncaptured.
        /// </summary>
        [JsonProperty("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Check results by Card networks on Card address and CVC at time of payment.
        /// </summary>
        [JsonProperty("checks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checks")]
#endif
        public ChargePaymentMethodDetailsCardChecks Checks { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        [JsonProperty("decremental_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("decremental_authorization")]
#endif
        public ChargePaymentMethodDetailsCardDecrementalAuthorization DecrementalAuthorization { get; set; }

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

        [JsonProperty("extended_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extended_authorization")]
#endif
        public ChargePaymentMethodDetailsCardExtendedAuthorization ExtendedAuthorization { get; set; }

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

        [JsonProperty("incremental_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("incremental_authorization")]
#endif
        public ChargePaymentMethodDetailsCardIncrementalAuthorization IncrementalAuthorization { get; set; }

        /// <summary>
        /// Installment details for this payment.
        ///
        /// For more information, see the <a
        /// href="https://stripe.com/docs/payments/installments">installments integration guide</a>.
        /// </summary>
        [JsonProperty("installments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("installments")]
#endif
        public ChargePaymentMethodDetailsCardInstallments Installments { get; set; }

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
        /// ID of the mandate used to make this payment or created by it.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public string Mandate { get; set; }

        /// <summary>
        /// True if this payment was marked as MOTO and out of scope for SCA.
        /// </summary>
        [JsonProperty("moto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("moto")]
#endif
        public bool? Moto { get; set; }

        [JsonProperty("multicapture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multicapture")]
#endif
        public ChargePaymentMethodDetailsCardMulticapture Multicapture { get; set; }

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
        /// If this card has network token credentials, this contains the details of the network
        /// token credentials.
        /// </summary>
        [JsonProperty("network_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_token")]
#endif
        public ChargePaymentMethodDetailsCardNetworkToken NetworkToken { get; set; }

        /// <summary>
        /// This is used by the financial networks to identify a transaction. Visa calls this the
        /// Transaction ID, Mastercard calls this the Trace ID, and American Express calls this the
        /// Acquirer Reference Data. This value will be present if it is returned by the financial
        /// network in the authorization response, and null otherwise.
        /// </summary>
        [JsonProperty("network_transaction_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_transaction_id")]
#endif
        public string NetworkTransactionId { get; set; }

        [JsonProperty("overcapture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("overcapture")]
#endif
        public ChargePaymentMethodDetailsCardOvercapture Overcapture { get; set; }

        [JsonProperty("partial_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("partial_authorization")]
#endif
        public ChargePaymentMethodDetailsCardPartialAuthorization PartialAuthorization { get; set; }

        /// <summary>
        /// Status of a card based on the card issuer.
        /// One of: <c>regulated</c>, or <c>unregulated</c>.
        /// </summary>
        [JsonProperty("regulated_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("regulated_status")]
#endif
        public string RegulatedStatus { get; set; }

        /// <summary>
        /// Populated if this transaction used 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure")]
#endif
        public ChargePaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet")]
#endif
        public ChargePaymentMethodDetailsCardWallet Wallet { get; set; }
    }
}
