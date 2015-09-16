using Newtonsoft.Json;
using Stripe.Entities;

namespace Stripe
{
    public class StripeAccount : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("charges_enabled")]
        public bool ChargesEnabled { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currencies_supported")]
        public string[] CurrenciesSupported { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("details_submitted")]
        public bool DetailsSubmitted { get; set; }

        [JsonProperty("transfers_enabled")]
        public bool TransfersEnabled { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("managed")]
        public string Managed { get; set; }

        [JsonProperty("bank_accounts")]
        public StripeList<StripeRecipientActiveAccount> BankAccounts { get; set; }

        [JsonProperty("business_url")]
        public string BusinessUrl { get; set; }

        [JsonProperty("legal_entity")]
        public StripeLegalEntity LegalEntity { get; set; }

        [JsonProperty("decline_charge_on")]
        public StripeDeclineChargeOn DeclineChargeOn { get; set; }

        [JsonProperty("support_phone")]
        public string SupportPhone { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        [JsonProperty("transfer_schedule")]
        public StripeTransferScheduleEntity TransferSchedule { get; set; }

        [JsonProperty("tos_acceptance")]
        public StripeTosAcceptanceEntity TosAcceptance { get; set; }

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("verification")]
        public StripeAccountVerification AccountVerification { get; set; }

        [JsonProperty("keys")]
        public StripeManagedAccountKeys Keys { get; set; }

        [JsonProperty("ssn_last_4")]
        public string SSN4 { get; set; }

    }

    public class StripeManagedAccountKeys
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("publishable")]
        public string Publishable { get; set; }

    }
}