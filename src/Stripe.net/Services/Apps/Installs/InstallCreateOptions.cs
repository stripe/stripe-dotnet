// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InstallCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the app to install.
        /// </summary>
        [JsonProperty("app")]
        [STJS.JsonPropertyName("app")]
        public string App { get; set; }

        /// <summary>
        /// The distribution channel to install from. Defaults to <c>public</c>. A private app must
        /// be installed on <c>private_test</c> or <c>private_live</c>, matching the mode of the API
        /// key.
        /// One of: <c>private_live</c>, <c>private_test</c>, <c>public</c>, or <c>testing</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// For OAuth apps, the PKCE code challenge used to issue the <c>auth_code</c> returned on
        /// the install. Must be 43 to 128 characters and contain only letters, numbers, <c>-</c>,
        /// <c>.</c>, <c>_</c>, and <c>~</c>. Only applies to installs made by the app developer or
        /// an embedding platform; ignored when an account installs its own private app.
        /// </summary>
        [JsonProperty("code_challenge")]
        [STJS.JsonPropertyName("code_challenge")]
        public string CodeChallenge { get; set; }

        /// <summary>
        /// The method used to derive <c>code_challenge</c>. Required when <c>code_challenge</c> is
        /// provided, and must be <c>S256</c>.
        /// </summary>
        [JsonProperty("code_challenge_method")]
        [STJS.JsonPropertyName("code_challenge_method")]
        public string CodeChallengeMethod { get; set; }
    }
}
