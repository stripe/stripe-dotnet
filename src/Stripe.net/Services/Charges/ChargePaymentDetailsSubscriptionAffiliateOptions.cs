// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentDetailsSubscriptionAffiliateOptions : INestedOptions
    {
        /// <summary>
        /// The name of the affiliate that originated the purchase.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
