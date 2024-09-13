// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionTaxIdCollectionOptions : INestedOptions
    {
        /// <summary>
        /// Enable tax ID collection during checkout. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
