namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BalanceDetails : StripeEntity<BalanceDetails>
    {
        /// <summary>
        /// Funds that are available for use.
        /// </summary>
        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }
    }
 }
