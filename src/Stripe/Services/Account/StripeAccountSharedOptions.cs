using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public abstract class StripeAccountSharedOptions
    {
        [JsonProperty("business_logo")]
        public string BusinessLogoFileId { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool? DebitNegativeBalances { get; set; }

        [JsonProperty("decline_charge_on[cvc_failure]")]
        public bool? DeclineChargeOnCvcFailure { get; set; }

        [JsonProperty("decline_charge_on[avs_failure]")]
        public bool? DeclineChargeOnAvsFailure { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external_account")]
        public StripeAccountCardOptions ExternalCardAccount { get; set; }

        [JsonProperty("external_account")]
        public StripeAccountBankAccountOptions ExternalBankAccount { get; set; }

        // legal entity

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        // tos acceptance

        // transfer schedule
    }
}
