// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUnsubscribeOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features from which you would like to unsubscribe.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public List<string> Features { get; set; }
    }
}
