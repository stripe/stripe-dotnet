namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransactionUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
