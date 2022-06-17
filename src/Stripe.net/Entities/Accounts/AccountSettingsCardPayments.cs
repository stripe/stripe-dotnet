// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardPayments : StripeEntity<AccountSettingsCardPayments>
    {
        [JsonProperty("decline_on")]
        public AccountSettingsDeclineOn DeclineOn { get; set; }

        /// <summary>
        /// The default text that appears on credit card statements when a charge is made. This
        /// field prefixes any dynamic <c>statement_descriptor</c> specified on the charge.
        /// <c>statement_descriptor_prefix</c> is useful for maximizing descriptor space for the
        /// dynamic portion.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix")]
        public string StatementDescriptorPrefix { get; set; }

        /// <summary>
        /// The Kana variation of the default text that appears on credit card statements when a
        /// charge is made (Japan only). This field prefixes any dynamic
        /// <c>statement_descriptor_suffix_kana</c> specified on the charge.
        /// <c>statement_descriptor_prefix_kana</c> is useful for maximizing descriptor space for
        /// the dynamic portion.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix_kana")]
        public string StatementDescriptorPrefixKana { get; set; }

        /// <summary>
        /// The Kanji variation of the default text that appears on credit card statements when a
        /// charge is made (Japan only). This field prefixes any dynamic
        /// <c>statement_descriptor_suffix_kanji</c> specified on the charge.
        /// <c>statement_descriptor_prefix_kanji</c> is useful for maximizing descriptor space for
        /// the dynamic portion.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix_kanji")]
        public string StatementDescriptorPrefixKanji { get; set; }
    }
}
