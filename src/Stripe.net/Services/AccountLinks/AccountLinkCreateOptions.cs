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
        /// The identifier of the account to create an account link for.
        /// </summary>
        [JsonProperty("collect")]
        public string Collect { get; set; }

        [Obsolete("Use RefreshUrl instead.")]
        [JsonProperty("failure_url")]
        public string FailureUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to if the account link is no longer valid.
        /// </summary>
        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon leaving or completing the linked flow
        /// successfully.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [Obsolete("Use ReturnUrl instead.")]
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The identifier of the account to create an account link for.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
