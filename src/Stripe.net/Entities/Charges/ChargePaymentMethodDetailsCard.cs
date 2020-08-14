namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCard : StripeEntity<ChargePaymentMethodDetailsCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>jcb</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Check results by Card networks on Card address and CVC at time of payment.
        /// </summary>
        [JsonProperty("checks")]
        public ChargePaymentMethodDetailsCardChecks Checks { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Card description. (Only for internal use only and not typically available in standard
        /// API requests.).
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

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
        /// Installment details for this payment (Mexico only).
        ///
        /// For more information, see the <a
        /// href="https://stripe.com/docs/payments/installments">installments integration guide</a>.
        /// </summary>
        [JsonProperty("installments")]
        public ChargePaymentMethodDetailsCardInstallments Installments { get; set; }

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
        /// True if this payment was marked as MOTO and out of scope for SCA.
        /// </summary>
        [JsonProperty("moto")]
        public bool? Moto { get; set; }

        /// <summary>
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>interac</c>, <c>jcb</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// Populated if this transaction used 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public ChargePaymentMethodDetailsCardThreeDSecure ThreeDSecure { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
        public ChargePaymentMethodDetailsCardWallet Wallet { get; set; }
    }
}
