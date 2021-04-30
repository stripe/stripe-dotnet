// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountLinkCreateOptions : BaseOptions
    {
        /// <summary>
        /// The identifier of the account to create an account link for.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Which information the platform needs to collect from the user. One of
        /// <c>currently_due</c> or <c>eventually_due</c>. Default is <c>currently_due</c>.
        /// One of: <c>currently_due</c>, or <c>eventually_due</c>.
        /// </summary>
        [JsonProperty("collect")]
        public string Collect { get; set; }

        /// <summary>
        /// The URL the user will be redirected to if the account link is expired, has been
        /// previously-visited, or is otherwise invalid. The URL you specify should attempt to
        /// generate a new account link with the same parameters used to create the original account
        /// link, then redirect the user to the new account link's URL so they can continue with
        /// Connect Onboarding. If a new account link cannot be generated or the redirect fails you
        /// should display a useful error to the user.
        /// </summary>
        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon leaving or completing the linked flow.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The type of account link the user is requesting. Possible values are
        /// <c>account_onboarding</c> or <c>account_update</c>.
        /// One of: <c>account_onboarding</c>, <c>account_update</c>, <c>custom_account_update</c>,
        /// or <c>custom_account_verification</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
