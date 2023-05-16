namespace Stripe
{
    using System.Collections.Generic;

    public class RawRequestOptions : RequestOptions
    {
        /// <summary>Gets or sets the API mode to use for the request.</summary>
        public ApiMode ApiMode { get; set; }

        /// <summary>Gets or sets additional headers for the request.</summary>
        public Dictionary<string, string> AdditionalHeaders { get; } = new Dictionary<string, string>();
    }
}
