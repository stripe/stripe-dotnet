// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountPersonAdditionalTosAcceptancesOptions : INestedOptions
    {
        /// <summary>
        /// Details on the legal guardian's acceptance of the main Stripe service agreement.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public AccountPersonAdditionalTosAcceptancesAccountOptions Account { get; set; }
    }
}
