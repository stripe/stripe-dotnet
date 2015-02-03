using System;
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

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [Obsolete("Use BankAccount.Country instead")]
        public string BankAccountCountry
        {
            get { return InternalBankAccountOptions == null ? string.Empty : InternalBankAccountOptions.Country; }
            set { (InternalBankAccountOptions ?? (InternalBankAccountOptions = new BankAccountOptions())).Country = value; }
        }

        [Obsolete("Use BankAccount.RoutingNumber instead")]
        public string BankAccountRoutingNumber
        {
            get { return InternalBankAccountOptions == null ? string.Empty : InternalBankAccountOptions.RoutingNumber; }
            set { (InternalBankAccountOptions ?? (InternalBankAccountOptions = new BankAccountOptions())).RoutingNumber = value; }
        }

        [Obsolete("Use BankAccount.AccountNumber instead")]
        public string BankAccountNumber
        {
            get { return InternalBankAccountOptions == null ? string.Empty : InternalBankAccountOptions.AccountNumber; }
            set { (InternalBankAccountOptions ?? (InternalBankAccountOptions = new BankAccountOptions())).AccountNumber = value; }
        }

        private BankAccountOptions InternalBankAccountOptions
        {
            get { return BankAccount as BankAccountOptions; }
            set { BankAccount = value; }
        }

        [JsonProperty("bank_account")]
        public IBankAccountOptions BankAccount { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}