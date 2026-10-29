// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferCreateToPayoutMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Options for bank account payout methods.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public OutboundTransferCreateToPayoutMethodOptionsBankAccountOptions BankAccount { get; set; }
    }
}
