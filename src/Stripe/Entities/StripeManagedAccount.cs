using Newtonsoft.Json;

namespace Stripe
{
    public class StripeManagedAccount : StripeAccount
    {
        //Account properties have been dramatically expanded.
        //StripeManagedAccount inherits StripeAccount and includes only the managed account specific properties

        [JsonProperty("debit_negative_balances")]
        public bool DebitNegativeBalances { get; set; }

        //hash
        [JsonProperty("decline_charge_on")]
        public StripeDeclineCharge DeclineChargeOn { get; set; }

        //list
        [JsonProperty("external_accounts")]
        public StripeList<StripeExternalAccount> StripeExternalAccountList { get; set; }

        //hash
        [JsonProperty("keys")]
        public StripeManagedAccountKeys Keys { get; set; }

        //hash
        [JsonProperty("legal_entity")]
        public StripeLegalEntity LegalEntity { get; set; }

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; }

        //hash
        [JsonProperty("tos_acceptance")]
        public StripeTosAcceptance TosAcceptance { get; set; }

        //hash
        [JsonProperty("transfer_schedule")]
        public StripeTransferSchedule TransferSchedule { get; set; }

        //hash
        [JsonProperty("verification")]
        public StripeAccountVerification Verification { get; set; }
    }
}
