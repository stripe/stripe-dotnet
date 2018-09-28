namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class FileLinkSharedOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// A future timestamp after which the link will no longer be usable.
        /// </summary>
        [FormProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
