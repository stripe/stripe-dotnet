// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountNoticeEmail : StripeEntity<AccountNoticeEmail>
    {
        /// <summary>
        /// Content of the email in plain text. The copy must match exactly the language that Stripe
        /// Compliance has approved for use.
        /// </summary>
        [JsonProperty("plain_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plain_text")]
#endif
        public string PlainText { get; set; }

        /// <summary>
        /// Email address of the recipient.
        /// </summary>
        [JsonProperty("recipient")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient")]
#endif
        public string Recipient { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [JsonProperty("subject")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subject")]
#endif
        public string Subject { get; set; }
    }
}
