// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferCreateOptions : BaseOptions
    {
        /// <summary>
        /// The amount, in specified currency, by which the FinancialAccount balance will increase
        /// due to the InboundTransfer.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// An optional, freeform description field intended to store metadata.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Object containing details about where the funds will originate from.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public InboundTransferCreateFromOptions From { get; set; }

        /// <summary>
        /// Object containing details about where the funds will land.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public InboundTransferCreateToOptions To { get; set; }
    }
}
