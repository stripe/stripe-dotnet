// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationFinalizeAmountOptions : BaseOptions
    {
        /// <summary>
        /// The final authorization amount that will be captured by the merchant. This amount is in
        /// the authorization currency and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("final_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("final_amount")]
#endif
        public long? FinalAmount { get; set; }

        /// <summary>
        /// Fleet-specific information for authorizations using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fleet")]
#endif
        public AuthorizationFleetOptions Fleet { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fuel")]
#endif
        public AuthorizationFuelOptions Fuel { get; set; }
    }
}
