using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Encapsulates a set of parameters Stripe requests for applications that do not use the OAuth-scoped auth tokens.
    /// When these OAuth-scoped auth tokens are not used, and instead a master account token is used, full card data can be passed via a Charge create, etc.
    /// When the OAuth-scoped auth tokens are used, cards, customers, and charges must all be created separately and linked via ids.
    /// 
    /// These fields are required if you get permission from Stripe to not use the OAuth-scoped auth tokens.
    /// This is typically the case when the client app is PCI-compliant and hosts all data in its own system instead of Stripe's
    /// </summary>
    public class BaseStripeRequest
    {
        /// <summary>
        /// The cardholder IP.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The user agent for the cardholder's browser.
        /// </summary>
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// The URL for the page containing the payment form.
        /// </summary>
        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// A unique identifier for a cardholder.
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// An identifier for the calling library, for example "Stripe.Net".
        /// </summary>
        [JsonProperty("payment_user_agent")]
        public string PaymentUserAgent { get; set; }
    }
}
