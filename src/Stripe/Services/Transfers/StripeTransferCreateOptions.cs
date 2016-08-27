using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTransferCreateOptions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccountId { get; set; }

        [JsonProperty("card")]
        public string CardId { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// You can use this parameter to transfer funds from a charge (or other transaction) before they are added to your available balance. A pending balance will transfer immediately but the funds will not become available until the original charge becomes available. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("source_transaction")]
        public string SourceTransaction { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
