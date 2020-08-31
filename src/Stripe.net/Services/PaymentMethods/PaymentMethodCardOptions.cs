namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardOptions : INestedOptions
    {
        /// <summary>
        /// The card's CVC. It is highly recommended to always include this value.
        /// </summary>
        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
