// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class HoldReleaseDetail : StripeEntity<HoldReleaseDetail>
    {
        /// <summary>
        /// The amount released by the ReserveRelease from this ReserveHold. A positive integer
        /// representing how much is released in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The ReserveRelease which released funds from this ReserveHold (e.g., resrel_123).
        /// </summary>
        [JsonProperty("reserve_release")]
        [STJS.JsonPropertyName("reserve_release")]
        public string ReserveRelease { get; set; }
    }
}
