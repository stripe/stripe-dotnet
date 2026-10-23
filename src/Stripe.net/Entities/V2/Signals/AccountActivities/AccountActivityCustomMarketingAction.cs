// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivityCustomMarketingAction : StripeEntity<AccountActivityCustomMarketingAction>
    {
        /// <summary>
        /// A description of the action.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The outcome of the action.
        /// One of: <c>failed</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("outcome")]
        [STJS.JsonPropertyName("outcome")]
        public string Outcome { get; set; }

        /// <summary>
        /// Additional user-defined properties of the action.
        /// </summary>
        [JsonProperty("properties")]
        [STJS.JsonPropertyName("properties")]
        public Dictionary<string, string> Properties { get; set; }
    }
}
