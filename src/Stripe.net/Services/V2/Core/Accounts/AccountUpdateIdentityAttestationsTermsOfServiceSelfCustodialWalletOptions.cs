// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceSelfCustodialWalletOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Account's acceptance of the Privy End User Terms.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountUpdateIdentityAttestationsTermsOfServiceSelfCustodialWalletAccountOptions Account { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of the platform's self-custodial wallet terms of
        /// service.
        /// </summary>
        [JsonProperty("platform")]
        [STJS.JsonPropertyName("platform")]
        public AccountUpdateIdentityAttestationsTermsOfServiceSelfCustodialWalletPlatformOptions Platform { get; set; }
    }
}
