// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCloseOptions : BaseOptions
    {
        /// <summary>
        /// Configurations on the Account to be closed. All configurations on the Account must be
        /// passed in for this request to succeed.
        /// One of: <c>card_creator</c>, <c>customer</c>, <c>merchant</c>, <c>recipient</c>, or
        /// <c>storer</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied_configurations")]
#endif
        public List<string> AppliedConfigurations { get; set; }
    }
}
