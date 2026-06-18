// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMoneyManagerCapabilitiesConsumerStorage : StripeEntity<AccountConfigurationMoneyManagerCapabilitiesConsumerStorage>
    {
        /// <summary>
        /// Can receive consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("inbound")]
        [STJS.JsonPropertyName("inbound")]
        public AccountConfigurationMoneyManagerCapabilitiesConsumerStorageInbound Inbound { get; set; }

        /// <summary>
        /// Can send consumer storage-type funds on Stripe.
        /// </summary>
        [JsonProperty("outbound")]
        [STJS.JsonPropertyName("outbound")]
        public AccountConfigurationMoneyManagerCapabilitiesConsumerStorageOutbound Outbound { get; set; }
    }
}
