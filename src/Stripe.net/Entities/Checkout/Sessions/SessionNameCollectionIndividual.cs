// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionNameCollectionIndividual : StripeEntity<SessionNameCollectionIndividual>
    {
        /// <summary>
        /// Indicates whether individual name collection is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the customer is required to complete the field before completing the Checkout
        /// Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
        [STJS.JsonPropertyName("optional")]
        public bool Optional { get; set; }
    }
}
