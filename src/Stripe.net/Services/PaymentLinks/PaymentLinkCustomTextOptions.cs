// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomTextOptions : INestedOptions
    {
        /// <summary>
        /// Custom text that should be displayed alongside shipping address collection.
        /// </summary>
        [JsonProperty("shipping_address")]
        public AddressOptions ShippingAddress { get; set; }

        /// <summary>
        /// Custom text that should be displayed alongside the payment confirmation button.
        /// </summary>
        [JsonProperty("submit")]
        public PaymentLinkCustomTextSubmitOptions Submit { get; set; }
    }
}
