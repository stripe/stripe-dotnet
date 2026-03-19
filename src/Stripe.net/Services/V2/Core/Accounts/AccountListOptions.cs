// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter only accounts that have all of the configurations specified. If omitted, returns
        /// all accounts regardless of which configurations they have.
        /// One of: <c>customer</c>, <c>merchant</c>, or <c>recipient</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
        [STJS.JsonPropertyName("applied_configurations")]
        public List<string> AppliedConfigurations { get; set; }

        /// <summary>
        /// Filter by whether the account is closed. If omitted, returns only Accounts that are not
        /// closed.
        /// </summary>
        [JsonProperty("closed")]
        [STJS.JsonPropertyName("closed")]
        public bool? Closed { get; set; }
    }
}
