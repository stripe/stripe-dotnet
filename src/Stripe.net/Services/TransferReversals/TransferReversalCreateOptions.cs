namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransferReversalCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in %s representing how much of this transfer to reverse. Can only
        /// reverse up to the unreversed amount remaining of the transfer. Partial transfer
        /// reversals are only allowed for transfers to Stripe Accounts. Defaults to the entire
        /// transfer amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a reversal object. It is displayed alongside
        /// the reversal in the Dashboard. This will be unset if you POST an empty value.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when reversing this
        /// transfer. If a full transfer reversal is given, the full application fee will be
        /// refunded. Otherwise, the application fee will be refunded with an amount proportional to
        /// the amount of the transfer reversed.
        /// </summary>
        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }
    }
}
