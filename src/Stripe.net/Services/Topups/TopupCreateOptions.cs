namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TopupCreateOptions : BaseOptions
    {
        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to top up $1.00 or 100 to top up ¥100, a 0-decimal currency) representing how much to top up your Stripe balance.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

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

        /// <summary>
        /// The ID of a source to transfer funds from. For most users, this should be left
        /// unspecified which will use the bank account that was set up in the dashboard for the
        /// specified currency. In test mode, this can be a test bank token (see
        /// <see href="https://stripe.com/docs/connect/testing#testing-top-ups">Testing
        /// Top-ups</see>).
        /// </summary>
        [JsonProperty("source")]
        public string SourceId { get; set; }

        /// <summary>
        /// Extra information about a top-up for the source’s bank statement. Limited to 15 ASCII
        /// characters.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
