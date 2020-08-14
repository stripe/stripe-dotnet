namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodDataAlipayOptions Alipay { get; set; }

        [JsonProperty("au_becs_debit")]
        public PaymentIntentPaymentMethodDataAuBecsDebitOptions AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentIntentPaymentMethodDataBacsDebitOptions BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodDataBancontactOptions Bancontact { get; set; }

        [JsonProperty("billing_details")]
        public PaymentIntentPaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        [JsonProperty("eps")]
        public PaymentIntentPaymentMethodDataEpsOptions Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentIntentPaymentMethodDataFpxOptions Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentIntentPaymentMethodDataGiropayOptions Giropay { get; set; }

        [JsonProperty("ideal")]
        public PaymentIntentPaymentMethodDataIdealOptions Ideal { get; set; }

        [JsonProperty("interac_present")]
        public PaymentIntentPaymentMethodDataInteracPresentOptions InteracPresent { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodDataP24Options P24 { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentIntentPaymentMethodDataSepaDebitOptions SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
