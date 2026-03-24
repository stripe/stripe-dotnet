// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantScriptStatementDescriptorOptions : INestedOptions
    {
        /// <summary>
        /// The Kana variation of statement_descriptor used for charges in Japan. Japanese statement
        /// descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("kana")]
        [STJS.JsonPropertyName("kana")]
        public AccountCreateConfigurationMerchantScriptStatementDescriptorKanaOptions Kana { get; set; }

        /// <summary>
        /// The Kanji variation of statement_descriptor used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("kanji")]
        [STJS.JsonPropertyName("kanji")]
        public AccountCreateConfigurationMerchantScriptStatementDescriptorKanjiOptions Kanji { get; set; }
    }
}
