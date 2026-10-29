// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountIdentityAttestationsTermsOfService : StripeEntity<AccountIdentityAttestationsTermsOfService>
    {
        /// <summary>
        /// Details on the Account's acceptance of the Stripe Services Agreement.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountIdentityAttestationsTermsOfServiceAccount Account { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service.
        /// </summary>
        [JsonProperty("money_manager")]
        [STJS.JsonPropertyName("money_manager")]
        public AccountIdentityAttestationsTermsOfServiceMoneyManager MoneyManager { get; set; }
    }
}
