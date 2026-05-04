// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodDataGiftCardOptions : INestedOptions
    {
        /// <summary>
        /// The gift card ID to redeem.
        /// </summary>
        [JsonProperty("gift_card")]
        [STJS.JsonPropertyName("gift_card")]
        public string GiftCard { get; set; }
    }
}
