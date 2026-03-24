// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentMethodConfigurationDetails : StripeEntity<SessionPaymentMethodConfigurationDetails>, IHasId
    {
        /// <summary>
        /// ID of the payment method configuration used.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// ID of the parent payment method configuration used.
        /// </summary>
        [JsonProperty("parent")]
        [STJS.JsonPropertyName("parent")]
        public string Parent { get; set; }
    }
}
