// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayments : StripeEntity<AccountSettingsPayments>
    {
        /// <summary>
        /// The default text that appears on credit card statements when a charge is made. This
        /// field prefixes any dynamic <c>statement_descriptor</c> specified on the charge.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The Kana variation of <c>statement_descriptor</c> used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_kana")]
        public string StatementDescriptorKana { get; set; }

        /// <summary>
        /// The Kanji variation of <c>statement_descriptor</c> used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_kanji")]
        public string StatementDescriptorKanji { get; set; }

        /// <summary>
        /// The Kana variation of <c>statement_descriptor_prefix</c> used for card charges in Japan.
        /// Japanese statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix_kana")]
        public string StatementDescriptorPrefixKana { get; set; }

        /// <summary>
        /// The Kanji variation of <c>statement_descriptor_prefix</c> used for card charges in
        /// Japan. Japanese statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix_kanji")]
        public string StatementDescriptorPrefixKanji { get; set; }
    }
}
