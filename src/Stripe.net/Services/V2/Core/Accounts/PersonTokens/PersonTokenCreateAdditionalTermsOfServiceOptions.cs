// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonTokenCreateAdditionalTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Person's acceptance of the [Stripe Services Agreement]; IP, date, and
        /// User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public PersonTokenCreateAdditionalTermsOfServiceAccountOptions Account { get; set; }
    }
}
