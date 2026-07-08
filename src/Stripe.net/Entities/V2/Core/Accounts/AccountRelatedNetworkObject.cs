// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRelatedNetworkObject : StripeEntity<AccountRelatedNetworkObject>
    {
        /// <summary>
        /// The ID of the network business profile associated with this Account.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }

        /// <summary>
        /// Closed Enum. The type of related network object.
        /// One of: <c>link</c>, or <c>network_business_profile</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
