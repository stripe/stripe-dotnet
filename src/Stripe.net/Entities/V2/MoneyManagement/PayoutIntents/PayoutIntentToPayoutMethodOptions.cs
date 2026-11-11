// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentToPayoutMethodOptions : StripeEntity<PayoutIntentToPayoutMethodOptions>
    {
        /// <summary>
        /// Options for bank account payout methods.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public PayoutIntentToPayoutMethodOptionsBankAccount BankAccount { get; set; }

        /// <summary>
        /// Options for check send payout methods.
        /// </summary>
        [JsonProperty("check_send")]
        [STJS.JsonPropertyName("check_send")]
        public PayoutIntentToPayoutMethodOptionsCheckSend CheckSend { get; set; }
    }
}
