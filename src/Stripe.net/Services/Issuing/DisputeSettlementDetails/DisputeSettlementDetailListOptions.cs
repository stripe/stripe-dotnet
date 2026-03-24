// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeSettlementDetailListOptions : ListOptions
    {
        /// <summary>
        /// Select the Issuing dispute settlement details for the given settlement.
        /// </summary>
        [JsonProperty("settlement")]
        [STJS.JsonPropertyName("settlement")]
        public string Settlement { get; set; }
    }
}
