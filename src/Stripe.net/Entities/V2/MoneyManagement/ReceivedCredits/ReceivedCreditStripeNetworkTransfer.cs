// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditStripeNetworkTransfer : StripeEntity<ReceivedCreditStripeNetworkTransfer>
    {
        /// <summary>
        /// Information about the sender of the network transfer.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public ReceivedCreditStripeNetworkTransferFrom From { get; set; }
    }
}
