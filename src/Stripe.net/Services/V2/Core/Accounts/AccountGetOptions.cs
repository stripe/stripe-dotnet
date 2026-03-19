// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountGetOptions : BaseOptions
    {
        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>configuration.customer</c>, <c>configuration.merchant</c>,
        /// <c>configuration.recipient</c>, <c>defaults</c>, <c>future_requirements</c>,
        /// <c>identity</c>, or <c>requirements</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}
