// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceTransitBalancesTotal : StripeEntity<BalanceTransitBalancesTotal>
    {
        /// <summary>
        /// Funds that are available for use.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public List<BalanceTransitBalancesTotalAvailable> Available { get; set; }

        /// <summary>
        /// Funds that are pending.
        /// </summary>
        [JsonProperty("pending")]
        [STJS.JsonPropertyName("pending")]
        public List<BalanceTransitBalancesTotalPending> Pending { get; set; }
    }
}
