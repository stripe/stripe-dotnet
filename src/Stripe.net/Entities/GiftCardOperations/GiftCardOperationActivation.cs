// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GiftCardOperationActivation : StripeEntity<GiftCardOperationActivation>
    {
        /// <summary>
        /// The balance amount of a gift card, including currency and amount.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public GiftCardOperationActivationBalance Balance { get; set; }
    }
}
