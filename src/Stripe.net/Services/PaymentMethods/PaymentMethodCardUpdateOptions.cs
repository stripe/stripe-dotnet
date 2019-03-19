namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardUpdateOptions : INestedOptions
    {
        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Two- or four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }
    }
}
