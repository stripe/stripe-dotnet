// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferNetworkDetailsAch : StripeEntity<OutboundTransferNetworkDetailsAch>
    {
        /// <summary>
        /// ACH Addenda record.
        /// </summary>
        [JsonProperty("addenda")]
        public string Addenda { get; set; }
    }
}
