// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferCreateOptions : BaseOptions
    {
        /// <summary>
        /// The amount, in specified currency, by which the FinancialAccount balance will increase
        /// due to the InboundTransfer.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public InboundTransferCreateAmountOptions Amount { get; set; }

        /// <summary>
        /// An optional, freeform description field intended to store metadata.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Object containing details about where the funds will originate from.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public InboundTransferCreateFromOptions From { get; set; }

        /// <summary>
        /// Object containing details about where the funds will land.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public InboundTransferCreateToOptions To { get; set; }
    }
}
