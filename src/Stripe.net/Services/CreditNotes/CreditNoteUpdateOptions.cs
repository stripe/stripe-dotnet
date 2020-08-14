namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditNoteUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
