// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateLicenseQuantityActionSetOptions : INestedOptions
    {
        /// <summary>
        /// The quantity to set.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }
    }
}
