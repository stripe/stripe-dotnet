// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferFailOptions : BaseOptions
    {
        /// <summary>
        /// Details about a failed InboundTransfer.
        /// </summary>
        [JsonProperty("failure_details")]
        [STJS.JsonPropertyName("failure_details")]
        public InboundTransferFailureDetailsOptions FailureDetails { get; set; }
    }
}
