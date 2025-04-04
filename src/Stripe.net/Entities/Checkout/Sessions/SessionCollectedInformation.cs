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
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public SessionCollectedInformationShippingDetails ShippingDetails { get; set; }
    }
}
