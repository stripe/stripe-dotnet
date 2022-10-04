// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BalanceIssuing : StripeEntity<BalanceIssuing>
    {
        /// <summary>
        /// Funds that are available for use.
        /// </summary>
        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }
    }
}
