// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountNoticeEmail : StripeEntity<AccountNoticeEmail>
    {
        /// <summary>
        /// Content of the email in plain text. The copy must match exactly the language that Stripe
        /// Compliance has approved for use.
        /// </summary>
        [JsonProperty("plain_text")]
        public string PlainText { get; set; }

        /// <summary>
        /// Email address of the recipient.
        /// </summary>
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// Subject of the email.
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
