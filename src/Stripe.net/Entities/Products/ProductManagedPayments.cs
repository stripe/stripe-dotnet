// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductManagedPayments : StripeEntity<ProductManagedPayments>
    {
        /// <summary>
        /// Whether this product is eligible for use with Managed Payments. Possible values are
        /// <c>eligible</c> and <c>ineligible</c>.
        /// One of: <c>eligible</c>, or <c>ineligible</c>.
        /// </summary>
        [JsonProperty("eligibility")]
        [STJS.JsonPropertyName("eligibility")]
        public string Eligibility { get; set; }

        /// <summary>
        /// The reasons this product is ineligible for use with Managed Payments, if any. This field
        /// isn't present if the product is eligible.
        /// </summary>
        [JsonProperty("ineligibility_reasons")]
        [STJS.JsonPropertyName("ineligibility_reasons")]
        public List<ProductManagedPaymentsIneligibilityReason> IneligibilityReasons { get; set; }
    }
}
