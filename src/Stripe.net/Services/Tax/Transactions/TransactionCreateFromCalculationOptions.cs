// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionCreateFromCalculationOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Tax Calculation ID to be used as input when creating the transaction.
        /// </summary>
        [JsonProperty("calculation")]
        public string Calculation { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Unix timestamp representing when the tax liability is assumed or reduced, which
        /// determines the liability posting period and handling in tax liability reports. The
        /// timestamp must fall within the <c>tax_date</c> and the current time, unless the
        /// <c>tax_date</c> is scheduled in advance. Defaults to the current time.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// A custom order or sale identifier, such as 'myOrder_123'. Must be unique across all
        /// transactions, including reversals.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
