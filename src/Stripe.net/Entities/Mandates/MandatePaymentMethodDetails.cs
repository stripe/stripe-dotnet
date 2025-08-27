// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MandatePaymentMethodDetails : StripeEntity<MandatePaymentMethodDetails>
    {
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public MandatePaymentMethodDetailsAcssDebit AcssDebit { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public MandatePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public MandatePaymentMethodDetailsAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public MandatePaymentMethodDetailsBacsDebit BacsDebit { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public MandatePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif
        public MandatePaymentMethodDetailsCashapp Cashapp { get; set; }

        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif
        public MandatePaymentMethodDetailsKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public MandatePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif
        public MandatePaymentMethodDetailsKrCard KrCard { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public MandatePaymentMethodDetailsLink Link { get; set; }

        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif
        public MandatePaymentMethodDetailsNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nz_bank_account")]
#endif
        public MandatePaymentMethodDetailsNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public MandatePaymentMethodDetailsPaypal Paypal { get; set; }

        [JsonProperty("payto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payto")]
#endif
        public MandatePaymentMethodDetailsPayto Payto { get; set; }

        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif
        public MandatePaymentMethodDetailsPix Pix { get; set; }

        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif
        public MandatePaymentMethodDetailsRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public MandatePaymentMethodDetailsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// This mandate corresponds with a specific payment method type. The
        /// <c>payment_method_details</c> includes an additional hash with the same name and
        /// contains mandate information that's specific to that payment method.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public MandatePaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
