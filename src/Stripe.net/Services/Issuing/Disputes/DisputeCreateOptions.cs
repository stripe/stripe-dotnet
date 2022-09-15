// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class DisputeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The dispute amount in the card's currency and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>. If
        /// not set, defaults to the full transaction amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Evidence provided for the dispute.
        /// </summary>
        [JsonProperty("evidence")]
        public DisputeEvidenceOptions Evidence { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the issuing transaction to create a dispute for. For transaction on Treasury
        /// FinancialAccounts, use <c>treasury.received_debit</c>.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// Params for disputes related to Treasury FinancialAccounts.
        /// </summary>
        [JsonProperty("treasury")]
        public DisputeTreasuryOptions Treasury { get; set; }
    }
}
