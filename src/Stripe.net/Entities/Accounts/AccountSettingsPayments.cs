// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsPayments : StripeEntity<AccountSettingsPayments>
    {
        /// <summary>
        /// When enabled, the customer of this Account will receive an email receipt when their
        /// payment is successful. If this parameter is not set, the default value is <c>false</c>.
        /// </summary>
        [JsonProperty("email_customers_on_successful_payment")]
        [STJS.JsonPropertyName("email_customers_on_successful_payment")]
        public bool? EmailCustomersOnSuccessfulPayment { get; set; }

        /// <summary>
        /// The default text that appears on credit card statements when a charge is made. This
        /// field prefixes any dynamic <c>statement_descriptor</c> specified on the charge.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The Kana variation of <c>statement_descriptor</c> used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_kana")]
        [STJS.JsonPropertyName("statement_descriptor_kana")]
        public string StatementDescriptorKana { get; set; }

        /// <summary>
        /// The Kanji variation of <c>statement_descriptor</c> used for charges in Japan. Japanese
        /// statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_kanji")]
        [STJS.JsonPropertyName("statement_descriptor_kanji")]
        public string StatementDescriptorKanji { get; set; }

        /// <summary>
        /// The Kana variation of <c>statement_descriptor_prefix</c> used for card charges in Japan.
        /// Japanese statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix_kana")]
        [STJS.JsonPropertyName("statement_descriptor_prefix_kana")]
        public string StatementDescriptorPrefixKana { get; set; }

        /// <summary>
        /// The Kanji variation of <c>statement_descriptor_prefix</c> used for card charges in
        /// Japan. Japanese statement descriptors have <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#set-japanese-statement-descriptors">special
        /// requirements</a>.
        /// </summary>
        [JsonProperty("statement_descriptor_prefix_kanji")]
        [STJS.JsonPropertyName("statement_descriptor_prefix_kanji")]
        public string StatementDescriptorPrefixKanji { get; set; }
    }
}
