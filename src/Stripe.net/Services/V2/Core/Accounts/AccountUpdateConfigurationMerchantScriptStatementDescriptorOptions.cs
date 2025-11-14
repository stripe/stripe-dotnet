// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationMerchantScriptStatementDescriptorOptions : INestedOptions
    {
        /// <summary>
        /// The Kana variation of statement_descriptor used for charges in Japan. Japanese statement
        /// descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
#endif
        public AccountUpdateConfigurationMerchantScriptStatementDescriptorKanaOptions Kana { get; set; }

        /// <summary>
        /// The Kanji variation of statement_descriptor used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
#endif
        public AccountUpdateConfigurationMerchantScriptStatementDescriptorKanjiOptions Kanji { get; set; }
    }
}
