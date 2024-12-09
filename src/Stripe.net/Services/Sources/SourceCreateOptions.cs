namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using Stripe.Infrastructure;

    public class SourceCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public string Alipay { get; set; }

        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        [JsonProperty("flow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flow")]
#endif
        public string Flow { get; set; }

        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public SourceMandateOptions Mandate { get; set; }

        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("original_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_source")]
#endif
        public string OriginalSource { get; set; }

        [JsonProperty("owner")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner")]
#endif
        public SourceOwnerOptions Owner { get; set; }

        [JsonProperty("receiver")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receiver")]
#endif
        public SourceReceiverOptions Receiver { get; set; }

        [JsonProperty("redirect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect")]
#endif
        public SourceRedirectOptions Redirect { get; set; }

        [JsonProperty("source_order")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_order")]
#endif
        public SourceSourceOrderOptions SourceOrder { get; set; }

        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        [JsonProperty("token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token")]
#endif
        public string Token { get; set; }

        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        [JsonProperty("usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage")]
#endif
        public string Usage { get; set; }

        /*
           Below we group all Source type specific paramters
        */

        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public SourceAcssDebitCreateOptions AcssDebit { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public SourceAuBecsDebitCreateOptions AuBecsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public SourceBancontactCreateOptions Bancontact { get; set; }

        [JsonProperty("card")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<string, SourceCardOptions> Card { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public SourceIdealCreateOptions Ideal { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public SourceKlarnaCreateOptions Klarna { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public SourceSepaDebitCreateOptions SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public SourceSofortCreateOptions Sofort { get; set; }

        [JsonProperty("three_d_secure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("three_d_secure")]
#endif
        public SourceThreeDSecureCreateOptions ThreeDSecure { get; set; }

        [JsonProperty("wechat")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat")]
#endif
        public SourceWechatCreateOptions Wechat { get; set; }
    }
}
