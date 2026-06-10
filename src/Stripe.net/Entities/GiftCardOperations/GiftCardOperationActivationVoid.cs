// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GiftCardOperationActivationVoid : StripeEntity<GiftCardOperationActivationVoid>
    {
        /// <summary>
        /// The operation that was voided.
        /// </summary>
        [JsonProperty("voided_operation")]
        [STJS.JsonPropertyName("voided_operation")]
        public string VoidedOperation { get; set; }
    }
}
