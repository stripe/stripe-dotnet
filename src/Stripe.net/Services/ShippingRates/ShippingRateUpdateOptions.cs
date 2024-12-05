// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ShippingRateUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the shipping rate can be used for new purchases. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Describes a fixed amount to charge for shipping. Must be present if type is
        /// <c>fixed_amount</c>.
        /// </summary>
        [JsonProperty("fixed_amount")]
        public ShippingRateFixedAmountOptions FixedAmount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One
        /// of <c>inclusive</c>, <c>exclusive</c>, or <c>unspecified</c>.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
