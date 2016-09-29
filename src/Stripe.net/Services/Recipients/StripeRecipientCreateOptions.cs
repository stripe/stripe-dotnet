using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRecipientCreateOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("bank_account")]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}