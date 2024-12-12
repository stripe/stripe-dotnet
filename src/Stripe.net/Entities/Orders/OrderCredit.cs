// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderCredit : StripeEntity<OrderCredit>
    {
        /// <summary>
        /// The amount of this credit to apply to the order.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Details for a gift card.
        /// </summary>
        [JsonProperty("gift_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gift_card")]
#endif
        public OrderCreditGiftCard GiftCard { get; set; }

        /// <summary>
        /// Line items on this order that are ineligible for this credit.
        /// </summary>
        [JsonProperty("ineligible_line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ineligible_line_items")]
#endif
        public List<string> IneligibleLineItems { get; set; }

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
