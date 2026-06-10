// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeEntryTax : StripeEntity<FeeEntryTax>
    {
        /// <summary>
        /// The tax amount calculated for this fee.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public FeeEntryTaxAmount Amount { get; set; }
    }
}
