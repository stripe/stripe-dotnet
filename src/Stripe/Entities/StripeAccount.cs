using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccount : StripeObject
    {
        //Account properties have been dramatically expanded.
        //StripeManagedAccount inherits StripeAccount and includes only the managed account specific properties

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        //business_logo is mentioned but cannot find information on its use/implementation
        [JsonProperty("business_logo")]
        public string BusinessLogo { get; set; }

        [JsonProperty("business_primary_color")]
        public string BusinessPrimaryColor { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        //Read Only Property
        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currencies_supported")]
        public string[] CurrenciesSupported { get; set; }

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("debit_negative_balances")]

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("decline_charge_on")]

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        //Read Only Property
        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("external_accounts")]

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("legal_entity")]

        [JsonProperty("managed")]
        public bool Managed { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("product_description")]

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("support_url")]
        public string SupportUrl { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("tos_acceptance")]

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("transfer_schedule")]

        //Read Only Property
        [JsonProperty("transfers_enabled")]
        public bool TransfersEnabled { get; set; }

        //See StripeManagedAccount - Property of Managed Accounts only
        //[JsonProperty("verification")]
    }
}
