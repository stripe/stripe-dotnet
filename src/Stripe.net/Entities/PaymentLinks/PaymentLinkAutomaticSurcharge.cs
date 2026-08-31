// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkAutomaticSurcharge : StripeEntity<PaymentLinkAutomaticSurcharge>
    {
        /// <summary>
        /// Determines which amount serves as the basis for calculating the surcharge.
        /// One of: <c>total_after_tax</c>, or <c>total_before_tax</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("calculation_basis")]
        [STJS.JsonPropertyName("calculation_basis")]
        public string CalculationBasis { get; set; }

        /// <summary>
        /// Indicates whether automatic surcharge is enabled for the payment link.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The surcharge provider used for this payment link.
        /// One of: <c>daikin</c>, <c>interpayments</c>, <c>proserv</c>, or <c>yeeld</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Specifies whether the surcharge is considered inclusive or exclusive of taxes.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
