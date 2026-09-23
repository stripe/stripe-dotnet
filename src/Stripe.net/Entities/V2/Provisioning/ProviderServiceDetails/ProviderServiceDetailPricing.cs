// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderServiceDetailPricing : StripeEntity<ProviderServiceDetailPricing>
    {
        [JsonProperty("component")]
        [STJS.JsonPropertyName("component")]
        public ProviderServiceDetailPricingComponent Component { get; set; }

        /// <summary>
        /// Legacy compatibility field for top-level paid pricing. Mirrors the single paid pricing
        /// entry when only one exists, or the entry marked <c>is_default</c>. If multiple paid
        /// pricing entries exist and none is default, this field is unset.
        /// </summary>
        [JsonProperty("paid")]
        [STJS.JsonPropertyName("paid")]
        public ProviderServiceDetailPricingPaid Paid { get; set; }

        /// <summary>
        /// Canonical top-level paid pricing entries for this service. When multiple entries are
        /// present, callers should read this field instead of <c>paid</c>.
        /// </summary>
        [JsonProperty("paid_pricing")]
        [STJS.JsonPropertyName("paid_pricing")]
        public List<ProviderServiceDetailPricingPaidPricing> PaidPricing { get; set; }

        /// <summary>
        /// One of: <c>component</c>, <c>free</c>, or <c>paid</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
