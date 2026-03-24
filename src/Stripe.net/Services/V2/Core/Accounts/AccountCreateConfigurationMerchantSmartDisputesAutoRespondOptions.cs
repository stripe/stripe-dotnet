// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantSmartDisputesAutoRespondOptions : INestedOptions
    {
        /// <summary>
        /// The preference for Smart Disputes auto-respond.
        /// One of: <c>inherit</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        [STJS.JsonPropertyName("preference")]
        public string Preference { get; set; }
    }
}
