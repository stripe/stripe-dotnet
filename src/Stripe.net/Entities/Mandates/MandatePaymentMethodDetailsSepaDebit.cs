// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MandatePaymentMethodDetailsSepaDebit : StripeEntity<MandatePaymentMethodDetailsSepaDebit>
    {
        /// <summary>
        /// The unique reference of the mandate.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The URL of the mandate. This URL generally contains sensitive information about the
        /// customer and should be shared with them exclusively.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
