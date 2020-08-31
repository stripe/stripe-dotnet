namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

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
        /// Debits and Transfers</a>.
        /// </summary>
        [JsonProperty("bank_account")]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// You can store multiple cards on a customer in order to charge the customer later. You
        /// can also store multiple debit cards on a recipient in order to transfer to those cards
        /// later.
        ///
        /// Related guide: <a href="https://stripe.com/docs/sources/cards">Card Payments with
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
