// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Requested amount of carbon removal units. Either this or <c>metric_tons</c> must be
        /// specified.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Publicly sharable reference for the end beneficiary of carbon removal. Assumed to be the
        /// Stripe account if not set.
        /// </summary>
        [JsonProperty("beneficiary")]
        public OrderBeneficiaryOptions Beneficiary { get; set; }

        /// <summary>
        /// Request currency for the order as a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a supported <a href="https://stripe.com/docs/currencies">settlement
        /// currency for your account</a>. If omitted, the account's default currency will be used.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Requested number of tons for the order. Either this or <c>amount</c> must be specified.
        /// </summary>
        [JsonProperty("metric_tons")]
        public decimal? MetricTons { get; set; }

        /// <summary>
        /// Unique identifier of the Climate product.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
