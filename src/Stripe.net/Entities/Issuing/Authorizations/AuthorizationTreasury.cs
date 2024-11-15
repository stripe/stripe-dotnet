// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationTreasury : StripeEntity<AuthorizationTreasury>
    {
        /// <summary>
        /// The array of <a
        /// href="https://stripe.com/docs/api/treasury/received_credits">ReceivedCredits</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("received_credits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_credits")]
#endif

        public List<string> ReceivedCredits { get; set; }

        /// <summary>
        /// The array of <a
        /// href="https://stripe.com/docs/api/treasury/received_debits">ReceivedDebits</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("received_debits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debits")]
#endif

        public List<string> ReceivedDebits { get; set; }

        /// <summary>
        /// The Treasury <a href="https://stripe.com/docs/api/treasury/transactions">Transaction</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif

        public string Transaction { get; set; }
    }
}
