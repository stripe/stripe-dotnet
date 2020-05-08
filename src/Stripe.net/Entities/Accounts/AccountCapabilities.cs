namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        [JsonProperty("au_becs_debit_payments")]
        public string AuBecsDebitPayments { get; set; }

        [JsonProperty("card_issuing")]
        public string CardIssuing { get; set; }

        [JsonProperty("card_payments")]
        public string CardPayments { get; set; }

        [JsonProperty("jcb_payments")]
        public string JcbPayments { get; set; }

        [JsonProperty("legacy_payments")]
        public string LegacyPayments { get; set; }

        [JsonProperty("tax_reporting_us_1099_k")]
        public string TaxReportingUs1099K { get; set; }

        [JsonProperty("tax_reporting_us_1099_misc")]
        public string TaxReportingUs1099Misc { get; set; }

        [JsonProperty("transfers")]
        public string Transfers { get; set; }
    }
}
