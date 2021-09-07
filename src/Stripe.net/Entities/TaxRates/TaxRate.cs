// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TaxRate : StripeEntity<TaxRate>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Defaults to <c>true</c>. When set to <c>false</c>, this tax rate cannot be used with new
        /// applications or Checkout Sessions, but will still work for subscriptions and invoices
        /// that already have it set.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An arbitrary string attached to the tax rate for your internal use only. It will not be
        /// visible to your customers.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the tax rates as it will appear to your customer on their receipt
        /// email, PDF, and the hosted invoice page.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// This specifies if the tax rate is inclusive or exclusive.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool Inclusive { get; set; }

        /// <summary>
        /// The jurisdiction for the tax rate. You can use this label field for tax reporting
        /// purposes. It also appears on your customer’s invoice.
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// This represents the tax rate percent out of 100.
        /// </summary>
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2:US">ISO 3166-2 subdivision code</a>,
        /// without country prefix. For example, "NY" for New York, United States.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The high-level tax type, such as <c>vat</c> or <c>sales_tax</c>.
        /// One of: <c>gst</c>, <c>hst</c>, <c>pst</c>, <c>qst</c>, <c>rst</c>, <c>sales_tax</c>, or
        /// <c>vat</c>.
        /// </summary>
        [JsonProperty("tax_type")]
        public string TaxType { get; set; }
    }
}
