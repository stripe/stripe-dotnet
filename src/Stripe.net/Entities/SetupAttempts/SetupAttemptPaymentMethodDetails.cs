// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupAttemptPaymentMethodDetails : StripeEntity<SetupAttemptPaymentMethodDetails>
    {
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public SetupAttemptPaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public SetupAttemptPaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public SetupAttemptPaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public SetupAttemptPaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public SetupAttemptPaymentMethodDetailsBancontact Bancontact { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public SetupAttemptPaymentMethodDetailsBoleto Boleto { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SetupAttemptPaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public SetupAttemptPaymentMethodDetailsCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public SetupAttemptPaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public SetupAttemptPaymentMethodDetailsIdeal Ideal { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public SetupAttemptPaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public SetupAttemptPaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public SetupAttemptPaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public SetupAttemptPaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public SetupAttemptPaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public SetupAttemptPaymentMethodDetailsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public SetupAttemptPaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public SetupAttemptPaymentMethodDetailsPayto Payto { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public SetupAttemptPaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SetupAttemptPaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public SetupAttemptPaymentMethodDetailsSofort Sofort { get; set; }

        /// <summary>
        /// The type of the payment method used in the SetupIntent (e.g., <c>card</c>). An
        /// additional hash is included on <c>payment_method_details</c> with a name matching this
        /// value. It contains confirmation-specific information for the payment method.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public SetupAttemptPaymentMethodDetailsUpi Upi { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public SetupAttemptPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
