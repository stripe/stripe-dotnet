// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsPaypayPaymentsSiteInDevelopment : StripeEntity<AccountSettingsPaypayPaymentsSiteInDevelopment>
    {
        /// <summary>
        /// Field to indicate that the website password has been provided.
        /// </summary>
        [JsonProperty("password_provided")]
        [STJS.JsonPropertyName("password_provided")]
        public bool PasswordProvided { get; set; }

        /// <summary>
        /// The username needed to access your business's website.
        /// </summary>
        [JsonProperty("username")]
        [STJS.JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
