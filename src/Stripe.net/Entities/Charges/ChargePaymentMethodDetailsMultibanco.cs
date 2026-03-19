// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsMultibanco : StripeEntity<ChargePaymentMethodDetailsMultibanco>
    {
        /// <summary>
        /// Entity number associated with this Multibanco payment.
        /// </summary>
        [JsonProperty("entity")]
        [STJS.JsonPropertyName("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Reference number associated with this Multibanco payment.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
