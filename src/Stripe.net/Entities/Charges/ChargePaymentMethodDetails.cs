namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetails : StripeEntity<ChargePaymentMethodDetails>
    {
        [JsonProperty("ach_credit_transfer")]
        public ChargePaymentMethodDetailsAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        public ChargePaymentMethodDetailsAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        public ChargePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("alipay")]
        public ChargePaymentMethodDetailsAlipay Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public ChargePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public ChargePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

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

        [JsonProperty("fpx")]
        public ChargePaymentMethodDetailsFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public ChargePaymentMethodDetailsGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public ChargePaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        public ChargePaymentMethodDetailsInteracPresent InteracPresent { get; set; }

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

        /// <summary>
        /// The type of transaction-specific details of the payment method used in the payment, one
        /// of <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>alipay</c>, <c>au_becs_debit</c>,
        /// <c>bancontact</c>, <c>card</c>, <c>card_present</c>, <c>eps</c>, <c>giropay</c>,
        /// <c>ideal</c>, <c>klarna</c>, <c>multibanco</c>, <c>p24</c>, <c>sepa_debit</c>,
        /// <c>sofort</c>, <c>stripe_account</c>, or <c>wechat</c>. An additional hash is included
        /// on <c>payment_method_details</c> with a name matching this value. It contains
        /// information specific to the payment method.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("wechat")]
        public ChargePaymentMethodDetailsWechat Wechat { get; set; }
    }
}
