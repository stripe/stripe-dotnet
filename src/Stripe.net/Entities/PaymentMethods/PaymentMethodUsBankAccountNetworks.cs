// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodUsBankAccountNetworks : StripeEntity<PaymentMethodUsBankAccountNetworks>
    {
        /// <summary>
        /// The preferred network.
        /// </summary>
        [JsonProperty("preferred")]
        [STJS.JsonPropertyName("preferred")]
        public string Preferred { get; set; }

        /// <summary>
        /// All supported networks.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("supported")]
        [STJS.JsonPropertyName("supported")]
        public List<string> Supported { get; set; }
    }
}
