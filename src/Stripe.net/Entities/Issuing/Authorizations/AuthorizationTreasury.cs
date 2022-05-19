// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthorizationTreasury : StripeEntity<AuthorizationTreasury>
    {
        /// <summary>
        /// The array of <a
        /// href="https://stripe.com/docs/api/treasury/received_credits">ReceivedCredits</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("received_credits")]
        public List<string> ReceivedCredits { get; set; }

        /// <summary>
        /// The array of <a
        /// href="https://stripe.com/docs/api/treasury/received_debits">ReceivedDebits</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("received_debits")]
        public List<string> ReceivedDebits { get; set; }

        /// <summary>
        /// The Treasury <a href="https://stripe.com/docs/api/treasury/transactions">Transaction</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
