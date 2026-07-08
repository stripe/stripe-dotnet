// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodNetworkBusinessProfileWallet : StripeEntity<PayoutMethodNetworkBusinessProfileWallet>
    {
        /// <summary>
        /// The Network ID of the Stripe profile.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
