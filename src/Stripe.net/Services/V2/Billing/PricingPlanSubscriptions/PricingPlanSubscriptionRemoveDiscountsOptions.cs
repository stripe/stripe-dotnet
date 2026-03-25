// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PricingPlanSubscriptionRemoveDiscountsOptions : BaseOptions
    {
        /// <summary>
        /// Expand to include additional data such as discount_details.
        /// One of: <c>discount_details</c>, or <c>pricing_plan_component_details</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }
    }
}
