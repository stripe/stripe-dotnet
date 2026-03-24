// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantScriptStatementDescriptor : StripeEntity<AccountConfigurationMerchantScriptStatementDescriptor>
    {
        /// <summary>
        /// The Kana variation of statement_descriptor used for charges in Japan. Japanese statement
        /// descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountConfigurationMerchantScriptStatementDescriptorKana Kana { get; set; }

        /// <summary>
        /// The Kanji variation of statement_descriptor used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountConfigurationMerchantScriptStatementDescriptorKanji Kanji { get; set; }
    }
}
