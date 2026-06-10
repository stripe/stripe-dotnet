// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GiftCardCreateOptions : BaseOptions
    {
        /// <summary>
        /// The brand of the gift card.
        /// One of: <c>fiserv_valuelink</c>, <c>givex</c>, or <c>svs</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Two-digit number representing the gift card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the gift card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The gift card number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// The gift card PIN.
        /// </summary>
        [JsonProperty("pin")]
        [STJS.JsonPropertyName("pin")]
        public string Pin { get; set; }
    }
}
