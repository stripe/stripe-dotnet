// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionNameCollection : StripeEntity<SessionNameCollection>
    {
        [JsonProperty("business")]
        [STJS.JsonPropertyName("business")]
        public SessionNameCollectionBusiness Business { get; set; }

        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public SessionNameCollectionIndividual Individual { get; set; }
    }
}
