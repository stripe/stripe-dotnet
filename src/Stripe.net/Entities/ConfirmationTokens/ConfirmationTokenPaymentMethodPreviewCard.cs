// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCard : StripeEntity<ConfirmationTokenPaymentMethodPreviewCard>
    {
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
        /// Checks on Card address and CVC if provided.
        /// </summary>
        [JsonProperty("checks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("checks")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardChecks Checks { get; set; }

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
        /// The brand to use when displaying the card, this accounts for customer's brand choice on
        /// dual-branded cards. Can be <c>american_express</c>, <c>cartes_bancaires</c>,
        /// <c>diners_club</c>, <c>discover</c>, <c>eftpos_australia</c>, <c>interac</c>,
        /// <c>jcb</c>, <c>mastercard</c>, <c>union_pay</c>, <c>visa</c>, or <c>other</c> and may
        /// contain more values in the future.
        /// </summary>
        [JsonProperty("display_brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_brand")]
#endif
        public string DisplayBrand { get; set; }

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
        /// Details of the original PaymentMethod that created this object.
        /// </summary>
        [JsonProperty("generated_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("generated_from")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardGeneratedFrom GeneratedFrom { get; set; }

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
        /// Contains information about card networks that can be used to process the payment.
        /// </summary>
        [JsonProperty("networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("networks")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardNetworks Networks { get; set; }

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
        /// Contains details on how this Card may be used for 3D Secure authentication.
        /// </summary>
        [JsonProperty("three_d_secure_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure_usage")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardThreeDSecureUsage ThreeDSecureUsage { get; set; }

        /// <summary>
        /// If this Card is part of a card wallet, this contains the details of the card wallet.
        /// </summary>
        [JsonProperty("wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet")]
#endif
        public ConfirmationTokenPaymentMethodPreviewCardWallet Wallet { get; set; }
    }
}
