// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsPaypayPaymentsSiteInDevelopmentOptions : INestedOptions
    {
        /// <summary>
        /// The password needed to access your business's website.
        /// </summary>
        [JsonProperty("password")]
        [STJS.JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// The username needed to access your business's website.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
