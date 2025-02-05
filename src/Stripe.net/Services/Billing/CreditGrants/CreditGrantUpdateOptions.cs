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
        /// The time when the billing credits created by this credit grant expire. If set to empty,
        /// the billing credits never expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Set of key-value pairs you can attach to an object. You can use this to store additional
        /// information about the object (for example, cost basis) in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
