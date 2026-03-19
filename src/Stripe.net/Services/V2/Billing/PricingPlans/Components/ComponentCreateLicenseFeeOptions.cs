// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ComponentCreateLicenseFeeOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the License Fee.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The version of the LicenseFee. Defaults to 'latest', if not specified.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
