namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CouponUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the coupon displayed to customers on, for instance invoices, or receipts. By
        /// default the <c>id</c> is shown if <c>name</c> is not set.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
