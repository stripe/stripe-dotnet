using System;
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

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [Obsolete("Use BankAccount.Country instead")]
        public string BankAccountCountry
        {
            get { return BankAccount == null ? string.Empty : BankAccount.Country; }
            set { (BankAccount ?? (BankAccount = new BankAccountOptions())).Country = value; }
        }

        [Obsolete("Use BankAccount.RoutingNumber instead")]
        public string BankAccountRoutingNumber
        {
            get { return BankAccount == null ? string.Empty : BankAccount.RoutingNumber; }
            set { (BankAccount ?? (BankAccount = new BankAccountOptions())).RoutingNumber = value; }
        }

        [Obsolete("Use BankAccount.AccountNumber instead")]
        public string BankAccountNumber
        {
            get { return BankAccount == null ? string.Empty : BankAccount.AccountNumber; }
            set { (BankAccount ?? (BankAccount = new BankAccountOptions())).AccountNumber = value; }
        }

        [JsonProperty("bank_account")]
        public BankAccountOptions BankAccount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}