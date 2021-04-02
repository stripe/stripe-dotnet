// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardPresent : StripeEntity<ChargePaymentMethodDetailsCardPresent>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>jcb</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The cardholder name as read from the card, in <a
        /// href="https://en.wikipedia.org/wiki/ISO/IEC_7813">ISO 7813</a> format. May include
        /// alphanumeric characters, special characters and first/last name separator (<c>/</c>).
        /// </summary>
        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range. (For internal use
        /// only and not typically available in standard API requests.).
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Authorization response cryptogram.
        /// </summary>
        [JsonProperty("emv_auth_data")]
        public string EmvAuthData { get; set; }

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
        /// whether two customers who’ve signed up with you are using the same card number, for
        /// example. For payment methods that tokenize card information (Apple Pay, Google Pay), the
        /// tokenized number might be provided instead of the underlying card number.
        ///
        /// <em>Starting May 1, 2021, card fingerprint in India for Connect will change to allow two
        /// fingerprints for the same card --- one for India and one for the rest of the world.</em>.
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
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
        public string GeneratedCard { get; set; }

        /// <summary>
        /// Issuer identification number of the card. (For internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonProperty("iin")]
        public string Iin { get; set; }

        /// <summary>
        /// The name of the card's issuing bank. (For internal use only and not typically available
        /// in standard API requests.).
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>interac</c>, <c>jcb</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// How card details were read in this transaction.
        /// One of: <c>contact_emv</c>, <c>contactless_emv</c>, <c>contactless_magstripe_mode</c>,
        /// <c>magnetic_stripe_fallback</c>, or <c>magnetic_stripe_track2</c>.
        /// </summary>
        [JsonProperty("read_method")]
        public string ReadMethod { get; set; }

        /// <summary>
        /// A collection of fields required to be displayed on receipts. Only required for EMV
        /// transactions.
        /// </summary>
        [JsonProperty("receipt")]
        public ChargePaymentMethodDetailsCardPresentReceipt Receipt { get; set; }
    }
}
