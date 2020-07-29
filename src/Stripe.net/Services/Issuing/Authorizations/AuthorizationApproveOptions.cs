namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthorizationApproveOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// If the authorization's <c>pending_request.is_amount_controllable</c> property is
        /// <c>true</c>, you may provide this value to control how much to hold for the
        /// authorization. Must be positive (use decline to decline an authorization request).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format. Individual keys can be
        /// unset by posting an empty value to them. All keys can be unset by posting an empty
        /// value to metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
