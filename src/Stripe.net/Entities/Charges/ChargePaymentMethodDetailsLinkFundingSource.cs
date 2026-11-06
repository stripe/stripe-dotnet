// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsLinkFundingSource : StripeEntity<ChargePaymentMethodDetailsLinkFundingSource>
    {
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public ChargePaymentMethodDetailsLinkFundingSourceCard Card { get; set; }

        /// <summary>
        /// The type of funding source used for this Link payment.
        /// One of: <c>card</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
