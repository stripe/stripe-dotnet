// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsBillsFeatures : StripeEntity<AccountSessionComponentsBillsFeatures>
    {
        /// <summary>
        /// Whether to enable the bill management feature that grants access to bill creation and
        /// payment.
        /// </summary>
        [JsonProperty("bill_management")]
        [STJS.JsonPropertyName("bill_management")]
        public bool BillManagement { get; set; }

        /// <summary>
        /// Whether to enable the send money feature that grants access to bill creation and
        /// payment.
        /// </summary>
        [JsonProperty("send_money")]
        [STJS.JsonPropertyName("send_money")]
        public bool SendMoney { get; set; }
    }
}
