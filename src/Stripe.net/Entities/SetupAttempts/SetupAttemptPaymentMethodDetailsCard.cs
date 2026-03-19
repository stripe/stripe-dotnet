// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupAttemptPaymentMethodDetailsCard : StripeEntity<SetupAttemptPaymentMethodDetailsCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Check results by Card networks on Card address and CVC at the time of authorization.
        /// </summary>
        [JsonProperty("checks")]
        [STJS.JsonPropertyName("checks")]
        public SetupAttemptPaymentMethodDetailsCardChecks Checks { get; set; }

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
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

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
        /// Issuer identification number of the card. (For internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonProperty("iin")]
        [STJS.JsonPropertyName("iin")]
        public string Iin { get; set; }

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
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>interac</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Populated if this authorization used 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure")]
        [STJS.JsonPropertyName("three_d_secure")]
        public SetupAttemptPaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
        [STJS.JsonPropertyName("wallet")]
        public SetupAttemptPaymentMethodDetailsCardWallet Wallet { get; set; }
    }
}
