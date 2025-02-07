// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Tax rates can be applied to <a
    /// href="https://stripe.com/invoicing/taxes/tax-rates">invoices</a>, <a
    /// href="https://stripe.com/billing/taxes/tax-rates">subscriptions</a> and <a
    /// href="https://stripe.com/payments/checkout/use-manual-tax-rates">Checkout Sessions</a>
    /// to collect tax.
    ///
    /// Related guide: <a href="https://stripe.com/billing/taxes/tax-rates">Tax rates</a>.
    /// </summary>
    public class TaxRate : StripeEntity<TaxRate>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Defaults to <c>true</c>. When set to <c>false</c>, this tax rate cannot be used with new
        /// applications or Checkout Sessions, but will still work for subscriptions and invoices
        /// that already have it set.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool Active { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An arbitrary string attached to the tax rate for your internal use only. It will not be
        /// visible to your customers.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The display name of the tax rates as it will appear to your customer on their receipt
        /// email, PDF, and the hosted invoice page.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Actual/effective tax rate percentage out of 100. For tax calculations with
        /// automatic_tax[enabled]=true, this percentage reflects the rate actually used to
        /// calculate tax based on the product's taxability and whether the user is registered to
        /// collect taxes in the corresponding jurisdiction.
        /// </summary>
        [JsonProperty("effective_percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_percentage")]
#endif
        public decimal? EffectivePercentage { get; set; }

        /// <summary>
        /// The amount of the tax rate when the <c>rate_type</c> is <c>flat_amount</c>. Tax rates
        /// with <c>rate_type</c> <c>percentage</c> can vary based on the transaction, resulting in
        /// this field being <c>null</c>. This field exposes the amount and currency of the flat tax
        /// rate.
        /// </summary>
        [JsonProperty("flat_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("flat_amount")]
#endif
        public TaxRateFlatAmount FlatAmount { get; set; }

        /// <summary>
        /// This specifies if the tax rate is inclusive or exclusive.
        /// </summary>
        [JsonProperty("inclusive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inclusive")]
#endif
        public bool Inclusive { get; set; }

        /// <summary>
        /// The jurisdiction for the tax rate. You can use this label field for tax reporting
        /// purposes. It also appears on your customer’s invoice.
        /// </summary>
        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The level of the jurisdiction that imposes this tax rate. Will be <c>null</c> for
        /// manually defined tax rates.
        /// One of: <c>city</c>, <c>country</c>, <c>county</c>, <c>district</c>, <c>multiple</c>, or
        /// <c>state</c>.
        /// </summary>
        [JsonProperty("jurisdiction_level")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction_level")]
#endif
        public string JurisdictionLevel { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Tax rate percentage out of 100. For tax calculations with automatic_tax[enabled]=true,
        /// this percentage includes the statutory tax rate of non-taxable jurisdictions.
        /// </summary>
        [JsonProperty("percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percentage")]
#endif
        public decimal Percentage { get; set; }

        /// <summary>
        /// Indicates the type of tax rate applied to the taxable amount. This value can be
        /// <c>null</c> when no tax applies to the location.
        /// One of: <c>flat_amount</c>, or <c>percentage</c>.
        /// </summary>
        [JsonProperty("rate_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_type")]
#endif
        public string RateType { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO 3166-2 subdivision code</a>,
        /// without country prefix. For example, "NY" for New York, United States.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// The high-level tax type, such as <c>vat</c> or <c>sales_tax</c>.
        /// One of: <c>amusement_tax</c>, <c>communications_tax</c>, <c>gst</c>, <c>hst</c>,
        /// <c>igst</c>, <c>jct</c>, <c>lease_tax</c>, <c>pst</c>, <c>qst</c>,
        /// <c>retail_delivery_fee</c>, <c>rst</c>, <c>sales_tax</c>, <c>service_tax</c>, or
        /// <c>vat</c>.
        /// </summary>
        [JsonProperty("tax_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_type")]
#endif
        public string TaxType { get; set; }
    }
}
