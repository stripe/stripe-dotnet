// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ComponentCreateLicenseFeeOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of the LicenseFee.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The version of the LicenseFee.
        /// </summary>
        [JsonProperty("version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("version")]
#endif
        public string Version { get; set; }
    }
}
