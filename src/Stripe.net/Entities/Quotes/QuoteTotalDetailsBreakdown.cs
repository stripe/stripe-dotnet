// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteTotalDetailsBreakdown : StripeEntity<QuoteTotalDetailsBreakdown>
    {
        /// <summary>
        /// The aggregated discounts.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<QuoteTotalDetailsBreakdownDiscount> Discounts { get; set; }

        /// <summary>
        /// The aggregated tax amounts by rate.
        /// </summary>
        [JsonProperty("taxes")]
        [STJS.JsonPropertyName("taxes")]
        public List<QuoteTotalDetailsBreakdownTax> Taxes { get; set; }
    }
}
