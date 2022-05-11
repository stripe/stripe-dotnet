// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkConsentCollectionOptions : INestedOptions
    {
        /// <summary>
        /// If set to <c>auto</c>, enables the collection of customer consent for promotional
        /// communications. The Checkout Session will determine whether to display an option to opt
        /// into promotional communication from the merchant depending on the customer's locale.
        /// Only available to US merchants.
        /// </summary>
        [JsonProperty("promotions")]
        public string Promotions { get; set; }
    }
}
