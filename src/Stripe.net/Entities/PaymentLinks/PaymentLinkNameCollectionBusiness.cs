// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkNameCollectionBusiness : StripeEntity<PaymentLinkNameCollectionBusiness>
    {
        /// <summary>
        /// Indicates whether business name collection is enabled for the payment link.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to complete the field before checking out. Defaults to
        /// <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
        [STJS.JsonPropertyName("optional")]
        public bool Optional { get; set; }
    }
}
