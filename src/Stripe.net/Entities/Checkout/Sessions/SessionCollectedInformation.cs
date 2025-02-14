// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCollectedInformation : StripeEntity<SessionCollectedInformation>
    {
        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
        public SessionCollectedInformationShippingDetails ShippingDetails { get; set; }
    }
}
