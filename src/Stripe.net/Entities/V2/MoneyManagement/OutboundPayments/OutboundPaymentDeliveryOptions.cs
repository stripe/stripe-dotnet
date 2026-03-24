// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentDeliveryOptions : StripeEntity<OutboundPaymentDeliveryOptions>
    {
        /// <summary>
        /// Open Enum. Speed of the payout.
        /// One of: <c>instant</c>, <c>next_business_day</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("speed")]
        [STJS.JsonPropertyName("speed")]
        public string Speed { get; set; }

        /// <summary>
        /// Open Enum. Method for bank account.
        /// One of: <c>automatic</c>, <c>local</c>, or <c>wire</c>.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// Delivery options for paper check.
        /// </summary>
        [JsonProperty("paper_check")]
        [STJS.JsonPropertyName("paper_check")]
        public OutboundPaymentDeliveryOptionsPaperCheck PaperCheck { get; set; }
    }
}
