namespace Stripe
{
    using System;
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
        /// Alternate name for refresh_url to ensure backwards compatibility.
        /// </summary>
        [Obsolete("Use RefreshUrl instead.")]
        [JsonProperty("failure_url")]
        public string FailureUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to if the account link is no longer valid. Your
        /// <c>refresh_url</c> should trigger a method on your server to create a new account link
        /// using this API, with the same parameters, and redirect the user to the new account link.
        /// </summary>
        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon leaving or completing the linked flow.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Alternate name for return_url to ensure backwards compatibility.
        /// </summary>
        [Obsolete("Use ReturnUrl instead.")]
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

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
