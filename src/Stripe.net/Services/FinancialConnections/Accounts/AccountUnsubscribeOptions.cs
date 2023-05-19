// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountUnsubscribeOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features from which you would like to unsubscribe.
        /// </summary>
        [JsonProperty("features")]
        public List<string> Features { get; set; }
    }
}
