using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTopupCreateOptions : StripeBaseOptions
    {
        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to top up $1.00 or 100 to top up ¥100, a 0-decimal currency) representing how much to top up your Stripe balance.
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// 3-letter ISO code for currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a Top-up object. It is displayed when in the web interface alongside the Top-up.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a Top-up object. It can be useful for storing additional information in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your bank statement. This may be up to 22 characters. The statement description may not include <>"' characters, and will appear on your bank statement in capital letters. Non-ASCII characters are automatically stripped. While most banks display this information consistently, some may display it incorrectly or not at all.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
