// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsSiteInDevelopmentOptions : INestedOptions
    {
        /// <summary>
        /// The password needed to access your business's website.
        /// </summary>
        [JsonProperty("password")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("password")]
#endif
        public string Password { get; set; }

        /// <summary>
        /// The username needed to access your business's website.
        /// </summary>
        [JsonProperty("username")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("username")]
#endif
        public string Username { get; set; }
    }
}
