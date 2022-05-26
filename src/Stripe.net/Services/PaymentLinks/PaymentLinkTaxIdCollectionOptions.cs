// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable tax ID collection.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
