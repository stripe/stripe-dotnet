// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardAccountFunding : StripeEntity<ChargePaymentMethodDetailsCardAccountFunding>
    {
        /// <summary>
        /// Indicates whether or not this charge is a funding transaction.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
