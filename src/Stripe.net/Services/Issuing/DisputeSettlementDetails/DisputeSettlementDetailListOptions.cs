// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeSettlementDetailListOptions : ListOptions
    {
        /// <summary>
        /// Select the Issuing dispute settlement details for the given settlement.
        /// </summary>
        [JsonProperty("settlement")]
        public string Settlement { get; set; }
    }
}
