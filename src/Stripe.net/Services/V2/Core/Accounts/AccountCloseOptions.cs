// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCloseOptions : BaseOptions
    {
        /// <summary>
        /// Configurations on the Account to be closed. All configurations on the Account must be
        /// passed in for this request to succeed.
        /// One of: <c>customer</c>, <c>merchant</c>, <c>recipient</c>, or <c>storer</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
        [STJS.JsonPropertyName("applied_configurations")]
        public List<string> AppliedConfigurations { get; set; }
    }
}
