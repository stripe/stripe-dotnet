using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRecipientUpdateOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("bank_account")]
        public StripeBankAccountOptions BankAccount { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }

        [JsonProperty("default_card")]
        public string DefaultCardId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}