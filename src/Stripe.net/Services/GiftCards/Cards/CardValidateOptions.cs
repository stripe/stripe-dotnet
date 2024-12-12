// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardValidateOptions : BaseOptions
    {
        /// <summary>
        /// The gift card code to be validated.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// The pin associated with the gift card. Not all gift cards have pins.
        /// </summary>
        [JsonProperty("giftcard_pin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giftcard_pin")]
#endif
        public string GiftcardPin { get; set; }
    }
}
