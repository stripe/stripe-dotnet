namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class TransferCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("destination")]
        public string Destination { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("source_transaction")]
        public string SourceTransaction { get; set; }

        [FormProperty("transfer_group")]
        public string TransferGroup { get; set; }

        [FormProperty("source_type")]
        public string SourceType { get; set; }
    }
}
