namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PayoutCreateOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// REQUIRED
        /// </summary>
        [FormProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// REQUIRED
        /// </summary>
        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("destination")]
        public string Destination { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("method")]
        public string Method { get; set; }

        [FormProperty("source_type")]
        public string SourceType { get; set; }

        [FormProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
