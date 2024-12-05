// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditUnderwritingRecordCreateFromApplicationOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details about the application submission.
        /// </summary>
        [JsonProperty("application")]
        public CreditUnderwritingRecordApplicationOptions Application { get; set; }

        /// <summary>
        /// Information about the company or person applying or holding the account.
        /// </summary>
        [JsonProperty("credit_user")]
        public CreditUnderwritingRecordCreditUserOptions CreditUser { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
