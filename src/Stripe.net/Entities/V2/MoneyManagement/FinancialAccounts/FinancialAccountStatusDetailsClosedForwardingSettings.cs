// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatusDetailsClosedForwardingSettings : StripeEntity<FinancialAccountStatusDetailsClosedForwardingSettings>
    {
        /// <summary>
        /// ID of the FinancialAccount that supplies funds to cover negative balances during or
        /// after this FinancialAccount's closure.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// ID of the FinancialAccount that receives funds forwarded from this FinancialAccount when
        /// it closes.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }
    }
}
