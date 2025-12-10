// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationIncrementOptions : BaseOptions
    {
        /// <summary>
        /// The amount to increment the authorization by. This amount is in the authorization
        /// currency and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonProperty("increment_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("increment_amount")]
#endif
        public long? IncrementAmount { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://docs.stripe.com/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_amount_controllable")]
#endif
        public bool? IsAmountControllable { get; set; }
    }
}
