// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCollectedInformation : StripeEntity<SessionCollectedInformation>
    {
        /// <summary>
        /// Customer’s business name for this Checkout Session.
        /// </summary>
        [JsonProperty("business_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_name")]
#endif
        public string BusinessName { get; set; }

        /// <summary>
        /// Customer’s individual name for this Checkout Session.
        /// </summary>
        [JsonProperty("individual_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual_name")]
#endif
        public string IndividualName { get; set; }

        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public SessionCollectedInformationShippingDetails ShippingDetails { get; set; }
    }
}
