// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentFxQuote : StripeEntity<PayoutIntentFxQuote>
    {
        /// <summary>
        /// Open Enum. Duration of the FX rate lock.
        /// One of: <c>five_minutes</c>, or <c>none</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("lock_duration")]
        [STJS.JsonPropertyName("lock_duration")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Timestamp when the rate lock expires. Null when rate locking is not supported.
        /// </summary>
        [JsonProperty("lock_expires_at")]
        [STJS.JsonPropertyName("lock_expires_at")]
        public DateTime? LockExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Open Enum. Lock status of the FX rate.
        /// One of: <c>active</c>, <c>expired</c>, or <c>none</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("lock_status")]
        [STJS.JsonPropertyName("lock_status")]
        public string LockStatus { get; set; }

        /// <summary>
        /// Key: source currency. Value: exchange rate from source currency to to_currency.
        /// </summary>
        [JsonProperty("rates")]
        [STJS.JsonPropertyName("rates")]
        public Dictionary<string, PayoutIntentFxQuoteRates> Rates { get; set; }

        /// <summary>
        /// The destination currency.
        /// </summary>
        [JsonProperty("to_currency")]
        [STJS.JsonPropertyName("to_currency")]
        public string ToCurrency { get; set; }
    }
}
