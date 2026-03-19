// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCollectedInformation : StripeEntity<SessionCollectedInformation>
    {
        /// <summary>
        /// Customer’s business name for this Checkout Session.
        /// </summary>
        [JsonProperty("business_name")]
        [STJS.JsonPropertyName("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Customer’s individual name for this Checkout Session.
        /// </summary>
        [JsonProperty("individual_name")]
        [STJS.JsonPropertyName("individual_name")]
        public string IndividualName { get; set; }

        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public SessionCollectedInformationShippingDetails ShippingDetails { get; set; }
    }
}
