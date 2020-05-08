namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("original_source")]
        public string OriginalSource { get; set; }

        [JsonProperty("owner")]
        public SourceOwnerOptions Owner { get; set; }

        [JsonProperty("receiver")]
        public SourceReceiverOptions Receiver { get; set; }

        [JsonProperty("redirect")]
        public SourceRedirectOptions Redirect { get; set; }

        [JsonProperty("source_order")]
        public SourceSourceOrderOptions SourceOrder { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}
