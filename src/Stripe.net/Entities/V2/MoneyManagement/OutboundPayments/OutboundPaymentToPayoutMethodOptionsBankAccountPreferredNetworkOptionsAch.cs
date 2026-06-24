// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch : StripeEntity<OutboundPaymentToPayoutMethodOptionsBankAccountPreferredNetworkOptionsAch>
    {
        /// <summary>
        /// Open Enum. ACH submission timing.
        /// One of: <c>next_day</c>, or <c>same_day</c>.
        /// </summary>
        [JsonProperty("submission")]
        [STJS.JsonPropertyName("submission")]
        public string Submission { get; set; }

        /// <summary>
        /// The transaction purpose for this ACH payment.
        /// </summary>
        [JsonProperty("transaction_purpose")]
        [STJS.JsonPropertyName("transaction_purpose")]
        public string TransactionPurpose { get; set; }
    }
}
