namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BalanceDetails : StripeEntity<BalanceDetails>
    {
        [JsonProperty("available")]
        public List<BalanceAmount> Available { get; set; }
    }
}
