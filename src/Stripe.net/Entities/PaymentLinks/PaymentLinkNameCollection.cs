// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkNameCollection : StripeEntity<PaymentLinkNameCollection>
    {
        [JsonProperty("business")]
        [STJS.JsonPropertyName("business")]
        public PaymentLinkNameCollectionBusiness Business { get; set; }

        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public PaymentLinkNameCollectionIndividual Individual { get; set; }
    }
}
