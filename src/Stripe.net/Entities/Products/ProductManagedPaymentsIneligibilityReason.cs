// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductManagedPaymentsIneligibilityReason : StripeEntity<ProductManagedPaymentsIneligibilityReason>
    {
        /// <summary>
        /// A code identifying the reason this product can't be used with Managed Payments.
        /// Additional values might be added as Managed Payments evolves its eligibility criteria.
        /// One of: <c>ineligible_tax_code</c>, or <c>no_tax_code_specified</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable description of the reason this product can't be used with Managed
        /// Payments.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
