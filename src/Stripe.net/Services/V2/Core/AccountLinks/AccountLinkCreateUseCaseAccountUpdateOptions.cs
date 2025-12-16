// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountLinkCreateUseCaseAccountUpdateOptions : INestedOptions
    {
        /// <summary>
        /// Specifies the requirements that Stripe collects from v2/core/accounts in the Onboarding
        /// flow.
        /// </summary>
        [JsonProperty("collection_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_options")]
#endif
        public AccountLinkCreateUseCaseAccountUpdateCollectionOptionsOptions CollectionOptions { get; set; }

        /// <summary>
        /// Open Enum. A v2/account can be configured to enable certain functionality. The
        /// configuration param targets the v2/account_link to collect information for the specified
        /// v2/account configuration/s.
        /// One of: <c>customer</c>, <c>merchant</c>, or <c>recipient</c>.
        /// </summary>
        [JsonProperty("configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configurations")]
#endif
        public List<string> Configurations { get; set; }

        /// <summary>
        /// The URL the user will be redirected to if the Account Link is expired, has been used, or
        /// is otherwise invalid. The URL you specify should attempt to generate a new Account Link
        /// with the same parameters used to create the original Account Link, then redirect the
        /// user to the new Account Link URL so they can continue the flow. Make sure to
        /// authenticate the user before redirecting to the new Account Link, in case the URL leaks
        /// to a third party. If a new Account Link can't be generated, or if the redirect fails,
        /// you should display a useful error to the user.
        /// </summary>
        [JsonProperty("refresh_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refresh_url")]
#endif
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon completing the linked flow.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }
    }
}
