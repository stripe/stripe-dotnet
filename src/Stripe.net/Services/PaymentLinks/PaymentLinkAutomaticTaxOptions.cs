// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// If <c>true</c>, tax will be calculated automatically using the customer's location.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
