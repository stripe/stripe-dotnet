// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentReturnOutboundPaymentOptions : BaseOptions
    {
        /// <summary>
        /// Optional hash to set the the return code.
        /// </summary>
        [JsonProperty("returned_details")]
        public OutboundPaymentReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
