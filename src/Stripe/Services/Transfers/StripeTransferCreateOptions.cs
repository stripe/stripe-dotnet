using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferCreateOptions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Obsolete("Use Destination or Connect instead.")]
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccountId { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("source_transaction")]
        public string SourceTransaction { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
