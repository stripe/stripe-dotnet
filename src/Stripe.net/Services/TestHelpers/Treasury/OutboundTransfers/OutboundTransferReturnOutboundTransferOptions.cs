// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferReturnOutboundTransferOptions : BaseOptions
    {
        /// <summary>
        /// Details about a returned OutboundTransfer.
        /// </summary>
        [JsonProperty("returned_details")]
        [STJS.JsonPropertyName("returned_details")]
        public OutboundTransferReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
