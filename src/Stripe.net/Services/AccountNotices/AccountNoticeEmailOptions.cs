// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountNoticeEmailOptions : INestedOptions
    {
        /// <summary>
        /// Content of the email in plain text. The copy must match exactly the language that Stripe
        /// Compliance has approved for use.
        /// </summary>
        [JsonProperty("plain_text")]
        [STJS.JsonPropertyName("plain_text")]
        public string PlainText { get; set; }

        /// <summary>
        /// Email address of the recipient.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [JsonProperty("subject")]
        [STJS.JsonPropertyName("subject")]
        public string Subject { get; set; }
    }
}
