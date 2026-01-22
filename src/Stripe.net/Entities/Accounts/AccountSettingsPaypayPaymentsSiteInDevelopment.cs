// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsSiteInDevelopment : StripeEntity<AccountSettingsPaypayPaymentsSiteInDevelopment>
    {
        /// <summary>
        /// Field to indicate that the website password has been provided.
        /// </summary>
        [JsonProperty("password_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("password_provided")]
#endif
        public bool PasswordProvided { get; set; }

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
