// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundDestinationDetailsPaypal : StripeEntity<RefundDestinationDetailsPaypal>
    {
        /// <summary>
        /// For refunds declined by the network, a decline code provided by the network which
        /// indicates the reason the refund failed.
        /// </summary>
        [JsonProperty("network_decline_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_decline_code")]
#endif
        public string NetworkDeclineCode { get; set; }
    }
}
