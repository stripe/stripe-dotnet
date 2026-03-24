// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsSmartDisputesOptions : INestedOptions
    {
        /// <summary>
        /// Smart Disputes auto-respond settings for the account.
        /// </summary>
        [JsonProperty("auto_respond")]
        [STJS.JsonPropertyName("auto_respond")]
        public AccountSettingsSmartDisputesAutoRespondOptions AutoRespond { get; set; }
    }
}
