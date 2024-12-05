// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferReturnOutboundTransferOptions : BaseOptions
    {
        /// <summary>
        /// Details about a returned OutboundTransfer.
        /// </summary>
        [JsonProperty("returned_details")]
        public OutboundTransferReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
