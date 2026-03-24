// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundDestinationDetailsPaypal : StripeEntity<RefundDestinationDetailsPaypal>
    {
        /// <summary>
        /// For refunds declined by the network, a decline code provided by the network which
        /// indicates the reason the refund failed.
        /// </summary>
        [JsonProperty("network_decline_code")]
        [STJS.JsonPropertyName("network_decline_code")]
        public string NetworkDeclineCode { get; set; }
    }
}
