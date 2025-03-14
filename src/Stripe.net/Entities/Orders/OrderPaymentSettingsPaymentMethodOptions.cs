// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptions : StripeEntity<OrderPaymentSettingsPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsIdeal Ideal { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsKlarna Klarna { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsLink Link { get; set; }

        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsP24 P24 { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsPaypal Paypal { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsSofort Sofort { get; set; }

        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsWechatPay WechatPay { get; set; }
    }
}
