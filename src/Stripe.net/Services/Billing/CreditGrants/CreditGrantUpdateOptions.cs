// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditGrantUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The time when the credit created by this credit grant will expire. If set to empty, the
        /// credit will never expire.
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
    }
}
