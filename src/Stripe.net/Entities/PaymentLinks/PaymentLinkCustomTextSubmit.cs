// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomTextSubmit : StripeEntity<PaymentLinkCustomTextSubmit>
    {
        /// <summary>
        /// Text may be up to 500 characters in length.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
