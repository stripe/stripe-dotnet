namespace Stripe
{
    using System;
    using System.Collections.Generic;

    public class RawRequestOptions : RequestOptions
    {
        /// <summary>Gets or sets the API mode to use for the request.</summary>
        [Obsolete("This property is no longer used and will be removed in a future release")]
        public ApiMode ApiMode { get; set; }

        /// <summary>Gets or sets additional headers for the request.</summary>
        public Dictionary<string, string> AdditionalHeaders { get; set; } = new Dictionary<string, string>();

        internal new RawRequestOptions Clone()
        {
            return (RawRequestOptions)this.MemberwiseClone();
        }
    }
}
