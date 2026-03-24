// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OrderPaymentSettingsPaymentMethodOptions : StripeEntity<OrderPaymentSettingsPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public OrderPaymentSettingsPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public OrderPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OrderPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public OrderPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public OrderPaymentSettingsPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public OrderPaymentSettingsPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public OrderPaymentSettingsPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public OrderPaymentSettingsPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public OrderPaymentSettingsPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public OrderPaymentSettingsPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public OrderPaymentSettingsPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public OrderPaymentSettingsPaymentMethodOptionsWechatPay WechatPay { get; set; }
    }
}
