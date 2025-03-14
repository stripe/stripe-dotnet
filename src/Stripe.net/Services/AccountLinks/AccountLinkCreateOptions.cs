// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountLinkCreateOptions : BaseOptions
    {
        /// <summary>
        /// The identifier of the account to create an account link for.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The collect parameter is deprecated. Use <c>collection_options</c> instead.
        /// One of: <c>currently_due</c>, or <c>eventually_due</c>.
        /// </summary>
        [JsonProperty("collect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collect")]
#endif
        public string Collect { get; set; }

        /// <summary>
        /// Specifies the requirements that Stripe collects from connected accounts in the Connect
        /// Onboarding flow.
        /// </summary>
        [JsonProperty("collection_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_options")]
#endif
        public AccountLinkCollectionOptionsOptions CollectionOptions { get; set; }

        /// <summary>
        /// The URL the user will be redirected to if the account link is expired, has been
        /// previously-visited, or is otherwise invalid. The URL you specify should attempt to
        /// generate a new account link with the same parameters used to create the original account
        /// link, then redirect the user to the new account link's URL so they can continue with
        /// Connect Onboarding. If a new account link cannot be generated or the redirect fails you
        /// should display a useful error to the user.
        /// </summary>
        [JsonProperty("refresh_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refresh_url")]
#endif
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon leaving or completing the linked flow.
        /// </summary>
        [JsonProperty("return_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_url")]
#endif
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The type of account link the user is requesting. Possible values are
        /// <c>account_onboarding</c> or <c>account_update</c>.
        /// One of: <c>account_onboarding</c>, <c>account_update</c>,
        /// <c>capital_financing_offer</c>, or <c>capital_financing_reporting</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
