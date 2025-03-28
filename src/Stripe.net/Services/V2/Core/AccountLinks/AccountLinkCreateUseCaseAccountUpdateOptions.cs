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
        /// Open Enum. A v2/account can be configured to enable certain functionality. The
        /// configuration param targets the v2/account_link to collect information for the specified
        /// v2/account configuration/s.
        /// </summary>
        [JsonProperty("configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("configurations")]
#endif
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
