// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteFxQuote : StripeEntity<OutboundPaymentQuoteFxQuote>
    {
        /// <summary>
        /// The duration the exchange rate lock remains valid from creation time. Allowed value is
        /// five_minutes or none.
        /// One of: <c>five_minutes</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_duration")]
        [STJS.JsonPropertyName("lock_duration")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Time at which the rate lock will expire, measured in seconds since the Unix epoch. Null
        /// when rate locking is not supported.
        /// </summary>
        [JsonProperty("lock_expires_at")]
        [STJS.JsonPropertyName("lock_expires_at")]
        public DateTime? LockExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Lock status of the quote. Transitions from active to expired once past the
        /// lock_expires_at timestamp. Value can be active, expired or none.
        /// One of: <c>active</c>, <c>expired</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_status")]
        [STJS.JsonPropertyName("lock_status")]
        public string LockStatus { get; set; }

        /// <summary>
        /// Key pair: from currency Value: exchange rate going from_currency -&gt; to_currency.
        /// </summary>
        [JsonProperty("rates")]
        [STJS.JsonPropertyName("rates")]
        public Dictionary<string, OutboundPaymentQuoteFxQuoteRates> Rates { get; set; }

        /// <summary>
        /// The currency that the transaction is exchanging to.
        /// </summary>
        [JsonProperty("to_currency")]
        [STJS.JsonPropertyName("to_currency")]
        public string ToCurrency { get; set; }
    }
}
