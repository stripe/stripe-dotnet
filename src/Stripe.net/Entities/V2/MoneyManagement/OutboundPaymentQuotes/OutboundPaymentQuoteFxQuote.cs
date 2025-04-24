// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentQuoteFxQuote : StripeEntity<OutboundPaymentQuoteFxQuote>
    {
        /// <summary>
        /// The duration the exchange rate lock remains valid from creation time. Allowed value is
        /// five_minutes.
        /// </summary>
        [JsonProperty("lock_duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_duration")]
#endif
        public string LockDuration { get; set; }

        /// <summary>
        /// Time at which the rate lock will expire, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("lock_expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_expires_at")]
#endif
        public DateTime LockExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Lock status of the quote. Transitions from active to expired once past the
        /// lock_expires_at timestamp. Value can be active or expired.
        /// One of: <c>active</c>, or <c>expired</c>.
        /// </summary>
        [JsonProperty("lock_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_status")]
#endif
        public string LockStatus { get; set; }

        /// <summary>
        /// Key pair: from currency Value: exchange rate going from_currency -&gt; to_currency.
        /// </summary>
        [JsonProperty("rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rates")]
#endif
        public Dictionary<string, OutboundPaymentQuoteFxQuoteRates> Rates { get; set; }

        /// <summary>
        /// The currency that the transaction is exchanging to.
        /// </summary>
        [JsonProperty("to_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to_currency")]
#endif
        public string ToCurrency { get; set; }
    }
}
