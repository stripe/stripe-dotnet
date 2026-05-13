// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeBatchAdjustments : StripeEntity<FeeBatchAdjustments>
    {
        /// <summary>
        /// The amount of tax adjusted for this batch.
        /// </summary>
        [JsonProperty("tax_adjustment")]
        [STJS.JsonPropertyName("tax_adjustment")]
        public V2.Amount TaxAdjustment { get; set; }
    }
}
