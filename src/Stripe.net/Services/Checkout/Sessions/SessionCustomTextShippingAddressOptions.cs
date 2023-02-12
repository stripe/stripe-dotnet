// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomTextShippingAddressOptions : INestedOptions
    {
        /// <summary>
        /// Text may be up to 1000 characters in length.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
