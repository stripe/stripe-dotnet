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
        /// Configuration specifying what this credit grant applies to. We currently only support
        /// <c>metered</c> prices that have a <a
        /// href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them.
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
        /// ID of the customer to receive the billing credits.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The time when the billing credits become effective-when they're eligible for use. It
        /// defaults to the current timestamp if not specified.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The time when the billing credits expire. If not specified, the billing credits don't
        /// expire.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. You can use this to store
        /// additional information about the object (for example, cost basis) in a structured
        /// format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A descriptive name shown in the Dashboard.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The desired priority for applying this credit grant. If not specified, it will be set to
        /// the default value of 50. The highest priority is 0 and the lowest is 100.
        /// </summary>
        [JsonProperty("priority")]
        public long? Priority { get; set; }
    }
}
