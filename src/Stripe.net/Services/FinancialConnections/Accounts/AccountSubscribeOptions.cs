// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountSubscribeOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features to which you would like to subscribe.
        /// </summary>
        [JsonProperty("features")]
        public List<string> Features { get; set; }
    }
}
