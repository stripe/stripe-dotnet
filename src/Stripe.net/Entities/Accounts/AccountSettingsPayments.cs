namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayments : StripeEntity<AccountSettingsPayments>
    {
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("statement_descriptor_kana")]
        public string StatementDescriptorKana { get; set; }

        [JsonProperty("statement_descriptor_kanji")]
        public string StatementDescriptorKanji { get; set; }
    }
}
