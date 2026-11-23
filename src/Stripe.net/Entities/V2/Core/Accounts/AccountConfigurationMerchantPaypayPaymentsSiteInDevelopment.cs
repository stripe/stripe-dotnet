// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantPaypayPaymentsSiteInDevelopment : StripeEntity<AccountConfigurationMerchantPaypayPaymentsSiteInDevelopment>
    {
        /// <summary>
        /// Whether a password needed to access the business's website has been provided.
        /// </summary>
        [JsonProperty("password_provided")]
        [STJS.JsonPropertyName("password_provided")]
        public bool PasswordProvided { get; set; }

        /// <summary>
        /// The username needed to access the business's website.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
