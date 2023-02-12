// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// Addenda record data associated with this OutboundTransfer.
        /// </summary>
        [JsonProperty("addenda")]
        public string Addenda { get; set; }
    }
}
