namespace Stripe
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class CreditNoteUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
