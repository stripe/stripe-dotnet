// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class InboundTransferFailOptions : BaseOptions
    {
        /// <summary>
        /// Details about a failed InboundTransfer.
        /// </summary>
        [JsonProperty("failure_details")]
        public InboundTransferFailureDetailsOptions FailureDetails { get; set; }
    }
}
