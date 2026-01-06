// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentDeliveryOptions : StripeEntity<OutboundPaymentDeliveryOptions>
    {
        /// <summary>
        /// Open Enum. Speed of the payout.
        /// One of: <c>instant</c>, <c>next_business_day</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("speed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("speed")]
#endif
        public string Speed { get; set; }

        /// <summary>
        /// Open Enum. Method for bank account.
        /// One of: <c>automatic</c>, <c>local</c>, or <c>wire</c>.
        /// </summary>
        [JsonProperty("bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
#endif
        public string BankAccount { get; set; }

        /// <summary>
        /// Delivery options for paper check.
        /// </summary>
        [JsonProperty("paper_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paper_check")]
#endif
        public OutboundPaymentDeliveryOptionsPaperCheck PaperCheck { get; set; }
    }
}
