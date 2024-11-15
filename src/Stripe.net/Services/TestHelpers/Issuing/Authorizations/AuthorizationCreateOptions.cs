// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationCreateOptions : BaseOptions
    {
        /// <summary>
        /// The total amount to attempt to authorize. This amount is in the provided currency, or
        /// defaults to the card's currency, and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif

        public AuthorizationAmountDetailsOptions AmountDetails { get; set; }

        /// <summary>
        /// How the card details were provided. Defaults to online.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_method")]
#endif

        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// Card associated with this authorization.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public string Card { get; set; }

        /// <summary>
        /// The currency of the authorization. If not provided, defaults to the currency of the
        /// card. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Fleet-specific information for authorizations using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fleet")]
#endif

        public AuthorizationFleetOptions Fleet { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fuel")]
#endif

        public AuthorizationFuelOptions Fuel { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://stripe.com/docs/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_amount_controllable")]
#endif

        public bool? IsAmountControllable { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_data")]
#endif

        public AuthorizationMerchantDataOptions MerchantData { get; set; }

        /// <summary>
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_data")]
#endif

        public AuthorizationNetworkDataOptions NetworkData { get; set; }

        /// <summary>
        /// Verifications that Stripe performed on information that the cardholder provided to the
        /// merchant.
        /// </summary>
        [JsonProperty("verification_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_data")]
#endif

        public AuthorizationVerificationDataOptions VerificationData { get; set; }

        /// <summary>
        /// The digital wallet used for this transaction. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>. Will populate as <c>null</c> when no digital
        /// wallet was utilized.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet")]
#endif

        public string Wallet { get; set; }
    }
}
