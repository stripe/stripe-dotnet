// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkConsentCollection : StripeEntity<PaymentLinkConsentCollection>
    {
        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications.
        /// </summary>
        [JsonProperty("promotions")]
        public string Promotions { get; set; }
    }
}
