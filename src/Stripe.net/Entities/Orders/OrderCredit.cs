// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderCredit : StripeEntity<OrderCredit>
    {
        /// <summary>
        /// The amount of this credit to apply to the order.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Details for a gift card.
        /// </summary>
        [JsonProperty("gift_card")]
        public OrderCreditGiftCard GiftCard { get; set; }

        /// <summary>
        /// Line items on this order that are ineligible for this credit.
        /// </summary>
        [JsonProperty("ineligible_line_items")]
        public List<string> IneligibleLineItems { get; set; }

        /// <summary>
        /// The type of credit to apply to the order, only <c>gift_card</c> currently supported.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
