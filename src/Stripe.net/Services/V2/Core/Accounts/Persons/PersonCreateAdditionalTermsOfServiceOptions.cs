// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonCreateAdditionalTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Stripe terms of service agreement.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public PersonCreateAdditionalTermsOfServiceAccountOptions Account { get; set; }
    }
}
