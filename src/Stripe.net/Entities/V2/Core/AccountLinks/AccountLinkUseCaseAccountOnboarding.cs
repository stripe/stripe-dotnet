// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountLinkUseCaseAccountOnboarding : StripeEntity<AccountLinkUseCaseAccountOnboarding>
    {
        /// <summary>
        /// Specifies the requirements that Stripe collects from v2/core/accounts in the Onboarding
        /// flow.
        /// </summary>
        [JsonProperty("collection_options")]
        [STJS.JsonPropertyName("collection_options")]
        public AccountLinkUseCaseAccountOnboardingCollectionOptions CollectionOptions { get; set; }

        /// <summary>
        /// Open Enum. A v2/core/account can be configured to enable certain functionality. The
        /// configuration param targets the v2/core/account_link to collect information for the
        /// specified v2/core/account configuration/s.
        /// One of: <c>customer</c>, <c>merchant</c>, <c>recipient</c>, or <c>storer</c>.
        /// </summary>
        [JsonProperty("configurations")]
        [STJS.JsonPropertyName("configurations")]
        public List<string> Configurations { get; set; }

        /// <summary>
        /// The URL the user will be redirected to if the AccountLink is expired, has been used, or
        /// is otherwise invalid. The URL you specify should attempt to generate a new AccountLink
        /// with the same parameters used to create the original AccountLink, then redirect the user
        /// to the new AccountLink’s URL so they can continue the flow. If a new AccountLink cannot
        /// be generated or the redirect fails you should display a useful error to the user. Please
        /// make sure to implement authentication before redirecting the user in case this URL is
        /// leaked to a third party.
        /// </summary>
        [JsonProperty("refresh_url")]
        [STJS.JsonPropertyName("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon completing the linked flow.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
