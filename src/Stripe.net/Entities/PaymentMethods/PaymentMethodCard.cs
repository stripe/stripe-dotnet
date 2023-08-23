// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCard : StripeEntity<PaymentMethodCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>jcb</c>, <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Checks on Card address and CVC if provided.
        /// </summary>
        [JsonProperty("checks")]
        public PaymentMethodCardChecks Checks { get; set; }

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
        /// <em>As of May 1, 2021, card fingerprint in India for Connect changed to allow two
        /// fingerprints for the same card---one for India and one for the rest of the world.</em>.
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
        /// Contains information about card networks that can be used to process the payment.
        /// </summary>
        [JsonProperty("networks")]
        public PaymentMethodCardNetworks Networks { get; set; }

        /// <summary>
        /// Contains details on how this Card may be used for 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure_usage")]
        public PaymentMethodCardThreeDSecureUsage ThreeDSecureUsage { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
        public PaymentMethodCardWallet Wallet { get; set; }
    }
}
