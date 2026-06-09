// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GiftCardOperationReloadVoid : StripeEntity<GiftCardOperationReloadVoid>
    {
        /// <summary>
        /// The balance amount of a gift card, including currency and amount.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public GiftCardOperationReloadVoidBalance Balance { get; set; }

        /// <summary>
        /// The operation that was voided.
        /// </summary>
        [JsonProperty("voided_operation")]
        [STJS.JsonPropertyName("voided_operation")]
        public string VoidedOperation { get; set; }
    }
}
