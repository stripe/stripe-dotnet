// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundDestinationDetailsGiftCard : StripeEntity<RefundDestinationDetailsGiftCard>
    {
        /// <summary>
        /// ID of the reload or activation GiftCardOperation created for this refund.
        /// </summary>
        [JsonProperty("gift_card_operation")]
        [STJS.JsonPropertyName("gift_card_operation")]
        public string GiftCardOperation { get; set; }
    }
}
