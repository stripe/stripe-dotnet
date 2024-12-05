// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountBalanceRefresh : StripeEntity<AccountBalanceRefresh>
    {
        /// <summary>
        /// The time at which the last refresh attempt was initiated. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("last_attempted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime LastAttemptedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the next balance refresh can be initiated. This value will be <c>null</c>
        /// when <c>status</c> is <c>pending</c>. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("next_refresh_available_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? NextRefreshAvailableAt { get; set; }

        /// <summary>
        /// The status of the last refresh attempt.
        /// One of: <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
