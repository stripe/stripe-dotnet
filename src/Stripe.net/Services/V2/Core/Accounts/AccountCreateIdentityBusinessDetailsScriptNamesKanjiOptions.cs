// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityBusinessDetailsScriptNamesKanjiOptions : INestedOptions
    {
        /// <summary>
        /// Registered name of the business.
        /// </summary>
        [JsonProperty("registered_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registered_name")]
#endif
        public string RegisteredName { get; set; }
    }
}
