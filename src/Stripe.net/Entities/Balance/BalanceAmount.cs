namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BalanceAmount : StripeEntity<BalanceAmount>
    {
        /// <summary>
        /// Balance amount.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Breakdown of balance by source types.
        /// </summary>
        [JsonProperty("source_types")]
        public Dictionary<string, long> SourceTypes { get; set; }
    }
 }
