// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditBalanceSummaryFilterApplicabilityScopePriceOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The price ID this credit grant should apply to.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
