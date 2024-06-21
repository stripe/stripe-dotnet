// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationFinalizeAmountOptions : BaseOptions
    {
        /// <summary>
        /// The final authorization amount that will be captured by the merchant. This amount is in
        /// the authorization currency and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("final_amount")]
        public long? FinalAmount { get; set; }

        /// <summary>
        /// Fleet-specific information for authorizations using Fleet cards.
        /// </summary>
        [JsonProperty("fleet")]
        public AuthorizationFleetOptions Fleet { get; set; }

        /// <summary>
        /// Information about fuel that was purchased with this transaction.
        /// </summary>
        [JsonProperty("fuel")]
        public AuthorizationFuelOptions Fuel { get; set; }
    }
}
