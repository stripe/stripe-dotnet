// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationIncrementOptions : BaseOptions
    {
        /// <summary>
        /// The amount to increment the authorization by. This amount is in the authorization
        /// currency and in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonProperty("increment_amount")]
        public long? IncrementAmount { get; set; }

        /// <summary>
        /// If set <c>true</c>, you may provide <a
        /// href="https://stripe.com/docs/api/issuing/authorizations/approve#approve_issuing_authorization-amount">amount</a>
        /// to control how much to hold for the authorization.
        /// </summary>
        [JsonProperty("is_amount_controllable")]
        public bool? IsAmountControllable { get; set; }
    }
}
