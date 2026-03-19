// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Tokenization is the process Stripe uses to collect sensitive card or bank account
    /// details, or personally identifiable information (PII), directly from your customers in a
    /// secure manner. A token representing this information is returned to your server to use.
    /// Use our <a href="https://docs.stripe.com/payments">recommended payments integrations</a>
    /// to perform this process on the client-side. This guarantees that no sensitive card data
    /// touches your server, and allows your integration to operate in a PCI-compliant way.
    ///
    /// If you can't use client-side tokenization, you can also create tokens using the API with
    /// either your publishable or secret API key. If your integration uses this method, you're
    /// responsible for any PCI compliance that it might require, and you must keep your secret
    /// API key safe. Unlike with client-side tokenization, your customer's information isn't
    /// sent directly to Stripe, so we can't determine how it's handled or stored.
    ///
    /// You can't store or use tokens more than once. To store card or bank account information
    /// for later use, create <a href="https://docs.stripe.com/api#customers">Customer</a>
    /// objects or <a href="https://stripe.com/api#external_accounts">External accounts</a>. <a
    /// href="https://docs.stripe.com/radar">Radar</a>, our integrated solution for automatic
    /// fraud protection, performs best with integrations that use client-side tokenization.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Token : StripeEntity<Token>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// These bank accounts are payment methods on <c>Customer</c> objects.
        ///
        /// On the other hand <a href="https://stripe.com/api#external_accounts">External
        /// Accounts</a> are transfer destinations on <c>Account</c> objects for connected accounts.
        /// They can be bank accounts or debit cards as well, and are documented in the links above.
        ///
        /// Related guide: <a href="https://stripe.com/payments/bank-debits-transfers">Bank debits
        /// and transfers</a>.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// You can store multiple cards on a customer in order to charge the customer later. You
        /// can also store multiple debit cards on a recipient in order to transfer to those cards
        /// later.
        ///
        /// Related guide: <a href="https://docs.stripe.com/sources/cards">Card payments with
        /// Sources</a>.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public Card Card { get; set; }

        /// <summary>
        /// IP address of the client that generates the token.
        /// </summary>
        [JsonProperty("client_ip")]
        [STJS.JsonPropertyName("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Type of the token: <c>account</c>, <c>bank_account</c>, <c>card</c>, or <c>pii</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Determines if you have already used this token (you can only use tokens once).
        /// </summary>
        [JsonProperty("used")]
        [STJS.JsonPropertyName("used")]
        public bool Used { get; set; }
    }
}
