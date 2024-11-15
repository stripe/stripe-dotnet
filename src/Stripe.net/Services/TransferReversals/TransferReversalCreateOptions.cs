// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransferReversalCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in cents (or local equivalent) representing how much of this transfer
        /// to reverse. Can only reverse up to the unreversed amount remaining of the transfer.
        /// Partial transfer reversals are only allowed for transfers to Stripe Accounts. Defaults
        /// to the entire transfer amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a reversal object. This will be unset if you
        /// POST an empty value.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when reversing this
        /// transfer. If a full transfer reversal is given, the full application fee will be
        /// refunded. Otherwise, the application fee will be refunded with an amount proportional to
        /// the amount of the transfer reversed.
        /// </summary>
        [JsonProperty("refund_application_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_application_fee")]
#endif

        public bool? RefundApplicationFee { get; set; }
    }
}
