namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationPendingRequest : StripeEntity<AuthorizationPendingRequest>
    {
        /// <summary>
        /// The additional amount Stripe will hold if the authorization is approved, in the
        /// currency, which is always the card's currency.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <c>Amount</c> to control how much to hold for the
        /// authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
        public bool IsAmountControllable { get; set; }

        /// <summary>
        /// The amount the merchant is requesting to be authorized in the
        /// <see cref="MerchantCurrency"/>.
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
