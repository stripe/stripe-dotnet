// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountStatusDetails : StripeEntity<FinancialAccountStatusDetails>
    {
        /// <summary>
        /// Details related to the closure of this FinancialAccount.
        /// </summary>
        [JsonProperty("closed")]
        public FinancialAccountStatusDetailsClosed Closed { get; set; }
    }
}
