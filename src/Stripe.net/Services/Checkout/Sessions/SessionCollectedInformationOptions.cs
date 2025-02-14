// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCollectedInformationOptions : INestedOptions
    {
        /// <summary>
        /// The shipping details to apply to this Session.
        /// </summary>
        [JsonProperty("shipping_details")]
        public SessionCollectedInformationShippingDetailsOptions ShippingDetails { get; set; }
    }
}
