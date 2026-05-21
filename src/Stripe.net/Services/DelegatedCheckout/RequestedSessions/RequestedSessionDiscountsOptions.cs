// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionDiscountsOptions : INestedOptions
    {
        /// <summary>
        /// Array of discount codes to apply. Pass an empty value to remove all applied discounts.
        /// </summary>
        [JsonProperty("codes")]
        [STJS.JsonPropertyName("codes")]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Whether to enforce strict eligibility for discount codes. Defaults to true. When false,
        /// invalid codes are returned in the discounts.invalid array instead of raising an error.
        /// </summary>
        [JsonProperty("enforce_strict_eligibility")]
        [STJS.JsonPropertyName("enforce_strict_eligibility")]
        public bool? EnforceStrictEligibility { get; set; }
    }
}
