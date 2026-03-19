// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodUpi : StripeEntity<PaymentMethodUpi>
    {
        /// <summary>
        /// Customer's unique Virtual Payment Address.
        /// </summary>
        [JsonProperty("vpa")]
        [STJS.JsonPropertyName("vpa")]
        public string Vpa { get; set; }
    }
}
