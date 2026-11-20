// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityAttestationsTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Account's acceptance of the Stripe Services Agreement.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public AccountUpdateIdentityAttestationsTermsOfServiceAccountOptions Account { get; set; }

        /// <summary>
        /// Terms of service acceptances for financial accounts backed by Fifth Third demand deposit
        /// accounts.
        /// </summary>
        [JsonProperty("business_demand_deposit_account_fifth_third")]
        [STJS.JsonPropertyName("business_demand_deposit_account_fifth_third")]
        public AccountUpdateIdentityAttestationsTermsOfServiceBusinessDemandDepositAccountFifthThirdOptions BusinessDemandDepositAccountFifthThird { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Issuing-specific terms of service.
        /// </summary>
        [JsonProperty("card_creator")]
        [STJS.JsonPropertyName("card_creator")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCardCreatorOptions CardCreator { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Consumer-specific terms of service.
        /// </summary>
        [JsonProperty("consumer_money_manager")]
        [STJS.JsonPropertyName("consumer_money_manager")]
        public AccountUpdateIdentityAttestationsTermsOfServiceConsumerMoneyManagerOptions ConsumerMoneyManager { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Consumer-privacy-disclosures-specific terms of
        /// service.
        /// </summary>
        [JsonProperty("consumer_privacy_disclosures")]
        [STJS.JsonPropertyName("consumer_privacy_disclosures")]
        public AccountUpdateIdentityAttestationsTermsOfServiceConsumerPrivacyDisclosuresOptions ConsumerPrivacyDisclosures { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Crypto-specific terms of service.
        /// </summary>
        [JsonProperty("crypto_money_manager")]
        [STJS.JsonPropertyName("crypto_money_manager")]
        public AccountUpdateIdentityAttestationsTermsOfServiceCryptoMoneyManagerOptions CryptoMoneyManager { get; set; }

        /// <summary>
        /// Details on the Account's acceptance of Treasury-specific terms of service.
        /// </summary>
        [JsonProperty("money_manager")]
        [STJS.JsonPropertyName("money_manager")]
        public AccountUpdateIdentityAttestationsTermsOfServiceMoneyManagerOptions MoneyManager { get; set; }

        /// <summary>
        /// Partial updates to the Account's self-custodial wallet terms of service acceptances.
        /// </summary>
        [JsonProperty("self_custodial_wallet")]
        [STJS.JsonPropertyName("self_custodial_wallet")]
        public AccountUpdateIdentityAttestationsTermsOfServiceSelfCustodialWalletOptions SelfCustodialWallet { get; set; }
    }
}
