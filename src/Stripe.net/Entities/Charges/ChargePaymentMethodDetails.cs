namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        public ChargePaymentMethodDetailsAchDebit AcssDebit { get; set; }

        [JsonProperty("alipay")]
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("bancontact")]
        public ChargePaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("bitcoin")]
        public ChargePaymentMethodDetailsBitcoin Bitcoin { get; set; }

        [JsonProperty("card")]
        public ChargePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        public ChargePaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("eps")]
        public ChargePaymentMethodDetailsEps Eps { get; set; }

        [JsonProperty("giropay")]
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("klarna")]
        public ChargePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("multibanco")]
        public ChargePaymentMethodDetailsMultibanco Multibanco { get; set; }

        [JsonProperty("p24")]
        public ChargePaymentMethodDetailsP24 P24 { get; set; }

        [JsonProperty("sepa_debit")]
        public ChargePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("stripe_account")]
        public ChargePaymentMethodDetailsStripeAccount StripeAccount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("wechat")]
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }
    }
}
