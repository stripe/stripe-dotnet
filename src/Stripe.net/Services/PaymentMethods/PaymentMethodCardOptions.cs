// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCardOptions : INestedOptions
    {
        /// <summary>
        /// The card's CVC. It is highly recommended to always include this value.
        /// </summary>
        [JsonProperty("cvc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc")]
#endif

        public string Cvc { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif

        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif

        public long? ExpYear { get; set; }

        /// <summary>
        /// Contains information about card networks used to process the payment.
        /// </summary>
        [JsonProperty("networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("networks")]
#endif

        public PaymentMethodCardNetworksOptions Networks { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif

        public string Number { get; set; }

        /// <summary>
        /// For backwards compatibility, you can alternatively provide a Stripe token (e.g., for
        /// Apple Pay, Amex Express Checkout, or legacy Checkout) into the card hash with format
        /// card: {token: "tok_visa"}.
        /// </summary>
        [JsonProperty("token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token")]
#endif

        public string Token { get; set; }
    }
}
