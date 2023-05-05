namespace Stripe
{
    using System.Collections.Generic;

    public class RawRequestOptions : RequestOptions
    {
        /// <summary>
        /// Enum for Encoding.
        /// </summary>
        public enum Encoding
        {
            /// <summary>
            /// Represents URL form encoding
            /// </summary>
            FORM,

            /// <summary>
            /// Represents JSON encoding
            /// </summary>
            JSON,
        }

        /// <summary>Gets or sets the options encoding for the request.</summary>
        internal Encoding OptionsEncoding { get; set; }

        /// <summary>Gets or sets additional headers for the request.</summary>
        internal Dictionary<string, string> AdditionalHeaders { get; set; }
    }
}
