namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Source : StripeEntity<Source>, IHasId, IHasMetadata, IHasObject, IPaymentSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("ach_credit_transfer")]
        public SourceAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonProperty("ach_debit")]
        public SourceAchDebit AchDebit { get; set; }

        [JsonProperty("acss_debit")]
        public SourceAcssDebit AcssDebit { get; set; }

        [JsonProperty("alipay")]
        public SourceAlipay Alipay { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("au_becs_debit")]
        public SourceAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bancontact")]
        public SourceBancontact Bancontact { get; set; }

        [JsonProperty("card")]
        public SourceCard Card { get; set; }

        [JsonProperty("card_present")]
        public SourceCardPresent CardPresent { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("code_verification")]
        public SourceCodeVerification CodeVerification { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("eps")]
        public SourceEps Eps { get; set; }

        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("giropay")]
        public SourceGiropay Giropay { get; set; }

        [JsonProperty("ideal")]
        public SourceIdeal Ideal { get; set; }

        [JsonProperty("klarna")]
        public SourceKlarna Klarna { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("multibanco")]
        public SourceMultibanco Multibanco { get; set; }

        [JsonProperty("owner")]
        public SourceOwner Owner { get; set; }

        [JsonProperty("p24")]
        public SourceP24 P24 { get; set; }

        [JsonProperty("receiver")]
        public SourceReceiver Receiver { get; set; }

        [JsonProperty("redirect")]
        public SourceRedirect Redirect { get; set; }

        [JsonProperty("sepa_credit_transfer")]
        public SourceSepaCreditTransfer SepaCreditTransfer { get; set; }

        [JsonProperty("sepa_debit")]
        public SourceSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public SourceSofort Sofort { get; set; }

        [JsonProperty("source_order")]
        public SourceSourceOrder SourceOrder { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("three_d_secure")]
        public SourceThreeDSecure ThreeDSecure { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("wechat")]
        public SourceWechat Wechat { get; set; }
    }
}
