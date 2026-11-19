// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantPaypayPaymentsSiteInDevelopmentOptions : INestedOptions
    {
        /// <summary>
        /// The password needed to access the business's website.
        /// </summary>
        [JsonProperty("password")]
        [STJS.JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// The username needed to access the business's website.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
