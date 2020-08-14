namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsInteracPresent : StripeEntity<ChargePaymentMethodDetailsInteracPresent>
    {
        /// <summary>
        /// Card brand. Can be <c>interac</c>, <c>mastercard</c> or <c>visa</c>.
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
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonProperty("generated_card")]
        public string GeneratedCard { get; set; }

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
        /// How were card details read in this transaction. Can be contact_emv, contactless_emv,
        /// magnetic_stripe_fallback, magnetic_stripe_track2, or contactless_magstripe_mode.
        /// </summary>
        [JsonProperty("read_method")]
        public string ReadMethod { get; set; }

        /// <summary>
        /// A collection of fields required to be displayed on receipts. Only required for EMV
        /// transactions.
        /// </summary>
        [JsonProperty("receipt")]
        public ChargePaymentMethodDetailsInteracPresentReceipt Receipt { get; set; }
    }
}
