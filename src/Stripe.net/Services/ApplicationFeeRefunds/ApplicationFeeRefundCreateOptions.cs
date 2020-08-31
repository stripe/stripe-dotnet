namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ApplicationFeeRefundCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer, in <em>%s</em>, representing how much of this fee to refund. Can
        /// refund only up to the remaining unrefunded amount of the fee.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
