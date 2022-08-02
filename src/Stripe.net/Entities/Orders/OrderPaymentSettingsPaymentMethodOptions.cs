// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptions : StripeEntity<OrderPaymentSettingsPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public OrderPaymentSettingsPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        public OrderPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public OrderPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("customer_balance")]
        public OrderPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("ideal")]
        public OrderPaymentSettingsPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonProperty("klarna")]
        public OrderPaymentSettingsPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("link")]
        public OrderPaymentSettingsPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("oxxo")]
        public OrderPaymentSettingsPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public OrderPaymentSettingsPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("paypal")]
        public OrderPaymentSettingsPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("sepa_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public OrderPaymentSettingsPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonProperty("wechat_pay")]
        public OrderPaymentSettingsPaymentMethodOptionsWechatPay WechatPay { get; set; }
    }
}
