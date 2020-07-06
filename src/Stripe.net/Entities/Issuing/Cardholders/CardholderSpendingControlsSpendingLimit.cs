namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderSpendingControlsSpendingLimit : StripeEntity<CardholderSpendingControlsSpendingLimit>
    {
        /// <summary>
        /// Maximum amount allowed to spend per time interval.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Categories on which to apply the spending limit. Leave this empty to limit all charges.
        /// </summary>
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// The time interval with which to apply this spending limit towards. Allowed values are
        /// <c>per_authorization</c>, <c>daily</c>, <c>weekly</c>, <c>monthly</c>, <c>yearly</c>,
        /// or <c>all_time</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
