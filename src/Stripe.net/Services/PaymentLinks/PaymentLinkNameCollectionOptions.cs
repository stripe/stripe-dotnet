// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkNameCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Controls settings applied for collecting the customer's business name.
        /// </summary>
        [JsonProperty("business")]
        [STJS.JsonPropertyName("business")]
        public PaymentLinkNameCollectionBusinessOptions Business { get; set; }

        /// <summary>
        /// Controls settings applied for collecting the customer's individual name.
        /// </summary>
        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public PaymentLinkNameCollectionIndividualOptions Individual { get; set; }
    }
}
