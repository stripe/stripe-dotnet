namespace Stripe
{
    using System;
    using System.Collections.Generic;

    public class RawRequestOptions : RequestOptions
    {
        /// <summary>Gets or sets additional headers for the request.</summary>
        public Dictionary<string, string> AdditionalHeaders { get; set; } = new Dictionary<string, string>();

        internal new RawRequestOptions Clone()
        {
            return (RawRequestOptions)this.MemberwiseClone();
        }
    }
}
