// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCreateCustomPricingUnitAmountOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The id of the custom pricing unit.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unit value for the custom pricing unit, as a string.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
