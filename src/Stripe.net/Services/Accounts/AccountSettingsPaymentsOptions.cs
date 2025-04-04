// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// The default text that appears on statements for non-card charges outside of Japan. For
        /// card charges, if you don't set a <c>statement_descriptor_prefix</c>, this text is also
        /// used as the statement descriptor prefix. In that case, if concatenating the statement
        /// descriptor suffix causes the combined statement descriptor to exceed 22 characters, we
        /// truncate the <c>statement_descriptor</c> text to limit the full descriptor to 22
        /// characters. For more information about statement descriptors and their requirements, see
        /// the <a href="https://docs.stripe.com/get-started/account/statement-descriptors">account
        /// settings documentation</a>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The Kana variation of <c>statement_descriptor</c> used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_kana")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_kana")]
#endif
        public string StatementDescriptorKana { get; set; }

        /// <summary>
        /// The Kanji variation of <c>statement_descriptor</c> used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_kanji")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_kanji")]
#endif
        public string StatementDescriptorKanji { get; set; }
    }
}
