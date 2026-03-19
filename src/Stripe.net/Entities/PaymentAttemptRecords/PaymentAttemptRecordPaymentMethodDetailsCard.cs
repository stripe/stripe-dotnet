// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsCard : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCard>
    {
        /// <summary>
        /// The authorization code of the payment.
        /// </summary>
        [JsonProperty("authorization_code")]
        [STJS.JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// One of: <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>,
        /// <c>unionpay</c>, <c>unknown</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// When using manual capture, a future timestamp at which the charge will be automatically
        /// refunded if uncaptured.
        /// </summary>
        [JsonProperty("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("capture_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Check results by Card networks on Card address and CVC at time of payment.
        /// </summary>
        [JsonProperty("checks")]
        [STJS.JsonPropertyName("checks")]
        public PaymentAttemptRecordPaymentMethodDetailsCardChecks Checks { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

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
        /// One of: <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// Issuer identification number of the card.
        /// </summary>
        [JsonProperty("iin")]
        [STJS.JsonPropertyName("iin")]
        public string Iin { get; set; }

        /// <summary>
        /// Installment details for this payment.
        /// </summary>
        [JsonProperty("installments")]
        [STJS.JsonPropertyName("installments")]
        public PaymentAttemptRecordPaymentMethodDetailsCardInstallments Installments { get; set; }

        /// <summary>
        /// The name of the card's issuing bank.
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
        /// True if this payment was marked as MOTO and out of scope for SCA.
        /// </summary>
        [JsonProperty("moto")]
        [STJS.JsonPropertyName("moto")]
        public bool Moto { get; set; }

        /// <summary>
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c>, or <c>unknown</c>.
        /// One of: <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>,
        /// <c>unionpay</c>, <c>unknown</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Advice code from the card network for the failed payment.
        /// </summary>
        [JsonProperty("network_advice_code")]
        [STJS.JsonPropertyName("network_advice_code")]
        public string NetworkAdviceCode { get; set; }

        /// <summary>
        /// Decline code from the card network for the failed payment.
        /// </summary>
        [JsonProperty("network_decline_code")]
        [STJS.JsonPropertyName("network_decline_code")]
        public string NetworkDeclineCode { get; set; }

        /// <summary>
        /// If this card has network token credentials, this contains the details of the network
        /// token credentials.
        /// </summary>
        [JsonProperty("network_token")]
        [STJS.JsonPropertyName("network_token")]
        public PaymentAttemptRecordPaymentMethodDetailsCardNetworkToken NetworkToken { get; set; }

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
        /// The transaction type that was passed for an off-session, Merchant-Initiated transaction,
        /// one of <c>recurring</c> or <c>unscheduled</c>.
        /// One of: <c>recurring</c>, or <c>unscheduled</c>.
        /// </summary>
        [JsonProperty("stored_credential_usage")]
        [STJS.JsonPropertyName("stored_credential_usage")]
        public string StoredCredentialUsage { get; set; }

        /// <summary>
        /// Populated if this transaction used 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure")]
        [STJS.JsonPropertyName("three_d_secure")]
        public PaymentAttemptRecordPaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
        [STJS.JsonPropertyName("wallet")]
        public PaymentAttemptRecordPaymentMethodDetailsCardWallet Wallet { get; set; }
    }
}
