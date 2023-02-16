// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomTextShippingAddressOptions : INestedOptions
    {
        /// <summary>
        /// Text may be up to 1000 characters in length.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
