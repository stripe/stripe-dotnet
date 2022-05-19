// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FinancialAccountStatusDetailsClosed : StripeEntity<FinancialAccountStatusDetailsClosed>
    {
        /// <summary>
        /// The array that contains reasons for a FinancialAccount closure.
        /// </summary>
        [JsonProperty("reasons")]
        public List<string> Reasons { get; set; }
    }
}
