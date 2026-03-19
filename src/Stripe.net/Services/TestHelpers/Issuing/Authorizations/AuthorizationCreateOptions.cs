// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationCreateOptions : BaseOptions
    {
        /// <summary>
        /// The total amount to attempt to authorize. This amount is in the provided currency, or
        /// defaults to the card's currency, and in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
        [STJS.JsonPropertyName("amount_details")]
        public AuthorizationAmountDetailsOptions AmountDetails { get; set; }

        /// <summary>
        /// How the card details were provided. Defaults to online.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
        [STJS.JsonPropertyName("authorization_method")]
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// Card associated with this authorization.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public string Card { get; set; }

        /// <summary>
        /// The currency of the authorization. If not provided, defaults to the currency of the
        /// card. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Fleet-specific information for authorizations using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
        [STJS.JsonPropertyName("fleet")]
        public AuthorizationFleetOptions Fleet { get; set; }

        /// <summary>
        /// Probability that this transaction can be disputed in the event of fraud. Assessed by
        /// comparing the characteristics of the authorization to card network rules.
        /// One of: <c>neutral</c>, <c>unknown</c>, <c>very_likely</c>, or <c>very_unlikely</c>.
        /// </summary>
        [JsonProperty("fraud_disputability_likelihood")]
        [STJS.JsonPropertyName("fraud_disputability_likelihood")]
        public string FraudDisputabilityLikelihood { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
        [STJS.JsonPropertyName("fuel")]
        public AuthorizationFuelOptions Fuel { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://docs.stripe.com/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
        [STJS.JsonPropertyName("is_amount_controllable")]
        public bool? IsAmountControllable { get; set; }

        /// <summary>
        /// The total amount to attempt to authorize. This amount is in the provided merchant
        /// currency, and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonProperty("merchant_amount")]
        [STJS.JsonPropertyName("merchant_amount")]
        public long? MerchantAmount { get; set; }

        /// <summary>
        /// The currency of the authorization. If not provided, defaults to the currency of the
        /// card. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("merchant_currency")]
        [STJS.JsonPropertyName("merchant_currency")]
        public string MerchantCurrency { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_data")]
        [STJS.JsonPropertyName("merchant_data")]
        public AuthorizationMerchantDataOptions MerchantData { get; set; }

        /// <summary>
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_data")]
        [STJS.JsonPropertyName("network_data")]
        public AuthorizationNetworkDataOptions NetworkData { get; set; }

        /// <summary>
        /// Stripe’s assessment of the fraud risk for this authorization.
        /// </summary>
        [JsonProperty("risk_assessment")]
        [STJS.JsonPropertyName("risk_assessment")]
        public AuthorizationRiskAssessmentOptions RiskAssessment { get; set; }

        /// <summary>
        /// Verifications that Stripe performed on information that the cardholder provided to the
        /// merchant.
        /// </summary>
        [JsonProperty("verification_data")]
        [STJS.JsonPropertyName("verification_data")]
        public AuthorizationVerificationDataOptions VerificationData { get; set; }

        /// <summary>
        /// The digital wallet used for this transaction. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>. Will populate as <c>null</c> when no digital
        /// wallet was utilized.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet")]
        [STJS.JsonPropertyName("wallet")]
        public string Wallet { get; set; }
    }
}
