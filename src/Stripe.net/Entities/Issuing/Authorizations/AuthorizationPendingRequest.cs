namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationPendingRequest : StripeEntity<AuthorizationPendingRequest>
    {
        /// <summary>
        /// The additional amount Stripe will hold if the authorization is approved, in the card's
        /// <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-pending-request-currency">currency</a>
        /// and in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency
        /// unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://stripe.com/docs/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
        public bool IsAmountControllable { get; set; }

        /// <summary>
        /// The amount the merchant is requesting to be authorized in the <c>merchant_currency</c>.
        /// The amount is in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The local currency the merchant is requesting to authorize.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }
    }
}
