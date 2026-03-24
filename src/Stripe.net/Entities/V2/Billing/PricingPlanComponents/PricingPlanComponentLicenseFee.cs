// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanComponentLicenseFee : StripeEntity<PricingPlanComponentLicenseFee>, IHasId
    {
        /// <summary>
        /// The ID of the License Fee.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the License Fee Version. If not specified, defaults to 'latest'.
        /// </summary>
        [JsonProperty("version")]
        [STJS.JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
