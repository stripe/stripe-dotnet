// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferFailOptions : BaseOptions
    {
        /// <summary>
        /// Details about a failed InboundTransfer.
        /// </summary>
        [JsonProperty("failure_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_details")]
#endif

        public InboundTransferFailureDetailsOptions FailureDetails { get; set; }
    }
}
