// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderCreditOptions : INestedOptions
    {
        /// <summary>
        /// The gift card to apply to the order.
        /// </summary>
        [JsonProperty("gift_card")]
        public string GiftCard { get; set; }

        /// <summary>
        /// The type of credit to apply to the order, only <c>gift_card</c> currently supported.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
