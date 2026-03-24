// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityIndividualAdditionalTermsOfService : StripeEntity<AccountIdentityIndividualAdditionalTermsOfService>
    {
        /// <summary>
        /// Stripe terms of service agreement.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountIdentityIndividualAdditionalTermsOfServiceAccount Account { get; set; }
    }
}
