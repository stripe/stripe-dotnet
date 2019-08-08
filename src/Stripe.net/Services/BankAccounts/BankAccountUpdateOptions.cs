namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BankAccountUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
