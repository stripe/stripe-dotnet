// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkShippingOptionOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Shipping Rate to use for this shipping option.
        /// </summary>
        [JsonProperty("shipping_rate")]
        [STJS.JsonPropertyName("shipping_rate")]
        public string ShippingRate { get; set; }
    }
}
