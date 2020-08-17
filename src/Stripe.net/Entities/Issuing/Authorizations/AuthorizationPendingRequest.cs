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
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
        public AuthorizationPendingRequestAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
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
