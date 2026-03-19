// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSubscribeOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features to which you would like to subscribe.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public List<string> Features { get; set; }
    }
}
