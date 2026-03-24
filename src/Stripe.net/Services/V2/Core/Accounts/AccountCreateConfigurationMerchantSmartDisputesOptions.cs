// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantSmartDisputesOptions : INestedOptions
    {
        /// <summary>
        /// Settings for Smart Disputes auto_respond.
        /// </summary>
        [JsonProperty("auto_respond")]
        [STJS.JsonPropertyName("auto_respond")]
        public AccountCreateConfigurationMerchantSmartDisputesAutoRespondOptions AutoRespond { get; set; }
    }
}
