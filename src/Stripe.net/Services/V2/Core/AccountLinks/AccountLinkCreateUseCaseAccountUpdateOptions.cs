// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountLinkCreateUseCaseAccountUpdateOptions : INestedOptions
    {
        /// <summary>
        /// Specifies the requirements that Stripe collects from v2/core/accounts in the Onboarding
        /// flow.
        /// </summary>
        [JsonProperty("collection_options")]
        [STJS.JsonPropertyName("collection_options")]
        public AccountLinkCreateUseCaseAccountUpdateCollectionOptionsOptions CollectionOptions { get; set; }

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
