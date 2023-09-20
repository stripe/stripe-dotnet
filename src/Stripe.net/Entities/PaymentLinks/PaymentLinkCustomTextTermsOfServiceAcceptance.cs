// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomTextTermsOfServiceAcceptance : StripeEntity<PaymentLinkCustomTextTermsOfServiceAcceptance>
    {
        /// <summary>
        /// Text may be up to 1000 characters in length.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
