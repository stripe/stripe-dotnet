// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionNameCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Controls settings applied for collecting the customer's business name on the session.
        /// </summary>
        [JsonProperty("business")]
        [STJS.JsonPropertyName("business")]
        public SessionNameCollectionBusinessOptions Business { get; set; }

        /// <summary>
        /// Controls settings applied for collecting the customer's individual name on the session.
        /// </summary>
        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public SessionNameCollectionIndividualOptions Individual { get; set; }
    }
}
