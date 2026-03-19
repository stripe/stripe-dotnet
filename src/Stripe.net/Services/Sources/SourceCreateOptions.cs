namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class SourceCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public string Alipay { get; set; }

        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public string Flow { get; set; }

        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("original_source")]
        [STJS.JsonPropertyName("original_source")]
        public string OriginalSource { get; set; }

        [JsonProperty("owner")]
        [STJS.JsonPropertyName("owner")]
        public SourceOwnerOptions Owner { get; set; }

        [JsonProperty("receiver")]
        [STJS.JsonPropertyName("receiver")]
        public SourceReceiverOptions Receiver { get; set; }

        [JsonProperty("redirect")]
        [STJS.JsonPropertyName("redirect")]
        public SourceRedirectOptions Redirect { get; set; }

        [JsonProperty("source_order")]
        [STJS.JsonPropertyName("source_order")]
        public SourceSourceOrderOptions SourceOrder { get; set; }

        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("token")]
        [STJS.JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        [STJS.JsonPropertyName("usage")]
        public string Usage { get; set; }

        /*
           Below we group all Source type specific paramters
        */

        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public SourceAcssDebitCreateOptions AcssDebit { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public SourceAuBecsDebitCreateOptions AuBecsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public SourceBancontactCreateOptions Bancontact { get; set; }

        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("card")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, SourceCardOptions> Card { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public SourceIdealCreateOptions Ideal { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public SourceKlarnaCreateOptions Klarna { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SourceSepaDebitCreateOptions SepaDebit { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public SourceSofortCreateOptions Sofort { get; set; }

        [JsonProperty("three_d_secure")]
        [STJS.JsonPropertyName("three_d_secure")]
        public SourceThreeDSecureCreateOptions ThreeDSecure { get; set; }

        [JsonProperty("wechat")]
        [STJS.JsonPropertyName("wechat")]
        public SourceWechatCreateOptions Wechat { get; set; }
    }
}
