// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkShippingOptionOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Shipping Rate to use for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate")]
        public string ShippingRate { get; set; }
    }
}
