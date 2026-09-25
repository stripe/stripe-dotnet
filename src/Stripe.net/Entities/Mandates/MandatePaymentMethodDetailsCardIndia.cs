// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MandatePaymentMethodDetailsCardIndia : StripeEntity<MandatePaymentMethodDetailsCardIndia>
    {
        /// <summary>
        /// The reason why the mandate has an <c>inactive</c> status. This field is only populated
        /// if the mandate is inactive.
        /// One of: <c>canceled</c>, <c>card_not_supported</c>, <c>currency_not_supported</c>,
        /// <c>expired</c>, <c>issuer_not_supported</c>, <c>processing_error</c>, or
        /// <c>undetermined</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("inactive_reason")]
        [STJS.JsonPropertyName("inactive_reason")]
        public string InactiveReason { get; set; }
    }
}
