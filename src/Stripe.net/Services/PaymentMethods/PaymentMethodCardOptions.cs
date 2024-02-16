// File generated from our OpenAPI spec
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
        /// Contains information about card networks used to process the payment.
        /// </summary>
        [JsonProperty("networks")]
        public PaymentMethodCardNetworksOptions Networks { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// For backwards compatibility, you can alternatively provide a Stripe token (e.g., for
        /// Apple Pay, Amex Express Checkout, or legacy Checkout) into the card hash with format
        /// card: {token: "tok_visa"}.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
