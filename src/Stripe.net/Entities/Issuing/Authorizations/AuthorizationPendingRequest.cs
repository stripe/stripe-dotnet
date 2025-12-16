// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPendingRequest : StripeEntity<AuthorizationPendingRequest>
    {
        /// <summary>
        /// The additional amount Stripe will hold if the authorization is approved, in the card's
        /// <a
        /// href="https://docs.stripe.com/api#issuing_authorization_object-pending-request-currency">currency</a>
        /// and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency
        /// unit</a>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif
        public AuthorizationPendingRequestAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://docs.stripe.com/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_amount_controllable")]
#endif
        public bool IsAmountControllable { get; set; }

        /// <summary>
        /// The amount the merchant is requesting to be authorized in the <c>merchant_currency</c>.
        /// The amount is in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonProperty("merchant_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_amount")]
#endif
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The local currency the merchant is requesting to authorize.
        /// </summary>
        [JsonProperty("merchant_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_currency")]
#endif
        public string MerchantCurrency { get; set; }

        /// <summary>
        /// The card network's estimate of the likelihood that an authorization is fraudulent. Takes
        /// on values between 1 and 99.
        /// </summary>
        [JsonProperty("network_risk_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_risk_score")]
#endif
        public long? NetworkRiskScore { get; set; }
    }
}
