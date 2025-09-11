namespace Stripe
{
    using System.Collections.Generic;

    public class RawRequestOptions : RequestOptions
    {
        /// <summary>Gets or sets the base URL for the raw request.</summary>
        /// <remarks>
        /// Use this to send API calls to e.g. files.stripe.com or
        /// a proxy address.
        /// </remarks>
        public string BaseUrl { get => this.InternalBaseUrl; set => this.InternalBaseUrl = value; }

        /// <summary>Gets or sets additional headers for the request.</summary>
        public Dictionary<string, string> AdditionalHeaders { get; set; } = new Dictionary<string, string>();

        internal new RawRequestOptions Clone()
        {
            return (RawRequestOptions)this.MemberwiseClone();
        }
    }
}
