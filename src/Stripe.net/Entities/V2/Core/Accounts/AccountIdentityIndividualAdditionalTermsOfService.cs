// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityIndividualAdditionalTermsOfService : StripeEntity<AccountIdentityIndividualAdditionalTermsOfService>
    {
        /// <summary>
        /// Stripe terms of service agreement.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public AccountIdentityIndividualAdditionalTermsOfServiceAccount Account { get; set; }
    }
}
