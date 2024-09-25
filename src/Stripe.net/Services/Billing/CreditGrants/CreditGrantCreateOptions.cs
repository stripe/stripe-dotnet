// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditGrantCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount of this credit grant.
        /// </summary>
        [JsonProperty("amount")]
        public CreditGrantAmountOptions Amount { get; set; }

        /// <summary>
        /// Configuration specifying what this credit grant applies to.
        /// </summary>
        [JsonProperty("applicability_config")]
        public CreditGrantApplicabilityConfigOptions ApplicabilityConfig { get; set; }

        /// <summary>
        /// The category of this credit grant.
        /// One of: <c>paid</c>, or <c>promotional</c>.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Id of the customer to whom the credit should be granted.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The time when the credit becomes effective i.e when it is eligible to be used. Defaults
        /// to the current timestamp if not specified.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The time when the credit will expire. If not specified, the credit will never expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object (ex: cost basis) in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A descriptive name shown in dashboard and on invoices.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
