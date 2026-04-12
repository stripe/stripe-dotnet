// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkAutomaticSurchargeOptions : INestedOptions
    {
        /// <summary>
        /// Determines which amount serves as the basis for calculating the surcharge.
        /// One of: <c>total_after_tax</c>, or <c>total_before_tax</c>.
        /// </summary>
        [JsonProperty("calculation_basis")]
        [STJS.JsonPropertyName("calculation_basis")]
        public string CalculationBasis { get; set; }

        /// <summary>
        /// Set to <c>true</c> to calculate surcharge automatically using the customer's card
        /// details and location.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies whether the surcharge is considered inclusive or exclusive of taxes.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
