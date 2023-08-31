// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CapabilityUpdateOptions : BaseOptions
    {
        /// <summary>
        /// To request a new capability for an account, pass true. There can be a delay before the
        /// requested capability becomes active. If the capability has any activation requirements,
        /// the response includes them in the <c>requirements</c> arrays.
        ///
        /// If a capability isn't permanent, you can remove it from the account by passing false.
        /// Most capabilities are permanent after they've been requested. Attempting to remove a
        /// permanent capability returns an error.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
