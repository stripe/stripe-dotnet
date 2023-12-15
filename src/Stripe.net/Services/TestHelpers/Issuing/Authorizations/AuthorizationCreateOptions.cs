// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationCreateOptions : BaseOptions
    {
        /// <summary>
        /// The total amount to attempt to authorize. This amount is in the provided currency, or
        /// defaults to the card's currency, and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
        public AuthorizationAmountDetailsOptions AmountDetails { get; set; }

        /// <summary>
        /// How the card details were provided. Defaults to online.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// Card associated with this authorization.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// The currency of the authorization. If not provided, defaults to the currency of the
        /// card. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://stripe.com/docs/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
        public bool? IsAmountControllable { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_data")]
        public AuthorizationMerchantDataOptions MerchantData { get; set; }

        /// <summary>
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_data")]
        public AuthorizationNetworkDataOptions NetworkData { get; set; }

        /// <summary>
        /// Verifications that Stripe performed on information that the cardholder provided to the
        /// merchant.
        /// </summary>
        [JsonProperty("verification_data")]
        public AuthorizationVerificationDataOptions VerificationData { get; set; }

        /// <summary>
        /// The digital wallet used for this transaction. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>. Will populate as <c>null</c> when no digital
        /// wallet was utilized.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet")]
        public string Wallet { get; set; }
    }
}
