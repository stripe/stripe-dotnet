// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderCreditOptions : INestedOptions
    {
        /// <summary>
        /// The gift card to apply to the order.
        /// </summary>
        [JsonProperty("gift_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gift_card")]
#endif
        public string GiftCard { get; set; }

        /// <summary>
        /// The type of credit to apply to the order, only <c>gift_card</c> currently supported.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
