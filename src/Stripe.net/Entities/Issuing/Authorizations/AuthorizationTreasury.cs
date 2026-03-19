// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationTreasury : StripeEntity<AuthorizationTreasury>
    {
        /// <summary>
        /// The array of <a
        /// href="https://docs.stripe.com/api/treasury/received_credits">ReceivedCredits</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("received_credits")]
        [STJS.JsonPropertyName("received_credits")]
        public List<string> ReceivedCredits { get; set; }

        /// <summary>
        /// The array of <a
        /// href="https://docs.stripe.com/api/treasury/received_debits">ReceivedDebits</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("received_debits")]
        [STJS.JsonPropertyName("received_debits")]
        public List<string> ReceivedDebits { get; set; }

        /// <summary>
        /// The Treasury <a href="https://docs.stripe.com/api/treasury/transactions">Transaction</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
