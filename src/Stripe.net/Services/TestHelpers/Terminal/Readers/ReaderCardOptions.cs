// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderCardOptions : INestedOptions
    {
        /// <summary>
        /// Card security code.
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
        /// Two- or four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public long? ExpYear { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif
        public string Number { get; set; }
    }
}
