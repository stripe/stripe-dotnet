namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceTransactionFeeDetail : StripeEntity<BalanceTransactionFeeDetail>
    {
        /// <summary>
        /// Amount of the fee, in cents.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// ID of the Connect application that earned the fee.
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Type of the fee, one of <c>application_fee</c>, <c>stripe_fee</c> or <c>tax</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
