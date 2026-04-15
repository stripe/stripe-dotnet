// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionAutomaticSurcharge : StripeEntity<SessionAutomaticSurcharge>
    {
        /// <summary>
        /// Determines which amount serves as the basis for calculating the surcharge.
        /// One of: <c>total_after_tax</c>, or <c>total_before_tax</c>.
        /// </summary>
        [JsonProperty("calculation_basis")]
        [STJS.JsonPropertyName("calculation_basis")]
        public string CalculationBasis { get; set; }

        /// <summary>
        /// Indicates whether automatic surcharge is enabled for the session.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The surcharge provider used for this session.
        /// One of: <c>interpayments</c>, or <c>yeeld</c>.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The status of the most recent surcharge calculation for this session.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_input</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Specifies whether the surcharge is considered inclusive or exclusive of taxes.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
