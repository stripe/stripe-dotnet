// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GiftCardOperationCashout : StripeEntity<GiftCardOperationCashout>
    {
        /// <summary>
        /// The balance amount of a gift card, including currency and amount.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public GiftCardOperationCashoutBalance Balance { get; set; }

        /// <summary>
        /// The balance before the operation.
        /// </summary>
        [JsonProperty("previous_balance")]
        [STJS.JsonPropertyName("previous_balance")]
        public GiftCardOperationCashoutPreviousBalance PreviousBalance { get; set; }
    }
}
