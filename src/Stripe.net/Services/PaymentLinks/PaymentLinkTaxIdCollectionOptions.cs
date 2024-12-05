// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Enable tax ID collection during checkout. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Describes whether a tax ID is required during checkout. Defaults to <c>never</c>.
        /// One of: <c>if_supported</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("required")]
        public string Required { get; set; }
    }
}
