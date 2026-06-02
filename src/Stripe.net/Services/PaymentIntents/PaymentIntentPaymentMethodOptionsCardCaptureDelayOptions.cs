// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardCaptureDelayOptions : INestedOptions
    {
        [JsonProperty("days")]
        [STJS.JsonPropertyName("days")]
        public long? Days { get; set; }

        [JsonProperty("hours")]
        [STJS.JsonPropertyName("hours")]
        public long? Hours { get; set; }
    }
}
