// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Tokenization is the process Stripe uses to collect sensitive card or bank account
    /// details, or personally identifiable information (PII), directly from your customers in a
    /// secure manner. A token representing this information is returned to your server to use.
    /// You should use our <a href="https://stripe.com/docs/payments">recommended payments
    /// integrations</a> to perform this process client-side. This ensures that no sensitive
    /// card data touches your server, and allows your integration to operate in a PCI-compliant
    /// way.
    ///
    /// If you cannot use client-side tokenization, you can also create tokens using the API
    /// with either your publishable or secret API key. Keep in mind that if your integration
    /// uses this method, you are responsible for any PCI compliance that may be required, and
    /// you must keep your secret API key safe. Unlike with client-side tokenization, your
    /// customer's information is not sent directly to Stripe, so we cannot determine how it is
    /// handled or stored.
    ///
    /// Tokens cannot be stored or used more than once. To store card or bank account
    /// information for later use, you can create <a
    /// href="https://stripe.com/docs/api#customers">Customer</a> objects or <a
    /// href="https://stripe.com/docs/api#external_accounts">Custom accounts</a>. Note that <a
    /// href="https://stripe.com/docs/radar">Radar</a>, our integrated solution for automatic
    /// fraud protection, performs best with integrations that use client-side tokenization.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token">Accept
    /// a payment with Charges and Tokens</a>.
    /// </summary>
    public class Token : StripeEntity<Token>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// These bank accounts are payment methods on <c>Customer</c> objects.
        ///
        /// On the other hand <a href="https://stripe.com/docs/api#external_accounts">External
        /// Accounts</a> are transfer destinations on <c>Account</c> objects for <a
        /// href="https://stripe.com/docs/connect/custom-accounts">Custom accounts</a>. They can be
        /// bank accounts or debit cards as well, and are documented in the links above.
        ///
        /// Related guide: <a href="https://stripe.com/docs/payments/bank-debits-transfers">Bank
        /// debits and transfers</a>.
        /// </summary>
        [JsonProperty("bank_account")]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// You can store multiple cards on a customer in order to charge the customer later. You
        /// can also store multiple debit cards on a recipient in order to transfer to those cards
        /// later.
        ///
        /// Related guide: <a href="https://stripe.com/docs/sources/cards">Card payments with
        /// Sources</a>.
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }

        /// <summary>
        /// IP address of the client that generated the token.
        /// </summary>
        [JsonProperty("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Type of the token: <c>account</c>, <c>bank_account</c>, <c>card</c>, or <c>pii</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Whether this token has already been used (tokens can be used only once).
        /// </summary>
        [JsonProperty("used")]
        public bool Used { get; set; }
    }
}
