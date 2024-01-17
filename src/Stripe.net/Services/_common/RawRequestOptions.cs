namespace Stripe
{
    using System.Collections.Generic;

    public class RawRequestOptions : RequestOptions
    {
        /// <summary>Gets or sets the API mode to use for the request.</summary>
        public ApiMode ApiMode { get; set; }

        /// <summary>Gets or sets additional headers for the request.</summary>
        public Dictionary<string, string> AdditionalHeaders { get; set; } = new Dictionary<string, string>();

        /// <summary>Gets or sets the value or Stripe-Context request header.</summary>
        public string StripeContext { get; set; }

        internal new RawRequestOptions Clone()
        {
            return (RawRequestOptions)this.MemberwiseClone();
        }
    }

    #pragma warning disable SA1402 // FileMayOnlyContainASingleType
    internal static class RawRequestOptionsExtensions
    {
        internal static RawRequestOptions WithUsage(this RawRequestOptions options, List<string> usage)
        {
            if (options == null)
            {
                return new RawRequestOptions() { Usage = usage };
            }

            var clone = options.Clone();
            clone.Usage = usage;
            return clone;
        }
    }
    #pragma warning restore SA1402 // FileMayOnlyContainASingleType
}
