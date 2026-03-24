// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsSmartDisputes : StripeEntity<AccountSettingsSmartDisputes>
    {
        [JsonProperty("auto_respond")]
        [STJS.JsonPropertyName("auto_respond")]
        public AccountSettingsSmartDisputesAutoRespond AutoRespond { get; set; }
    }
}
