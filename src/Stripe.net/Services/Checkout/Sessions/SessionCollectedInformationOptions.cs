// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionCollectedInformationOptions : INestedOptions
    {
        /// <summary>
        /// The shipping details to apply to this Session.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public SessionCollectedInformationShippingDetailsOptions ShippingDetails { get; set; }
    }
}
