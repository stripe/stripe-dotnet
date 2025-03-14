// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCapabilitiesTreasuryFifthThirdOptions : INestedOptions
    {
        /// <summary>
        /// Passing true requests the capability for the account, if it is not already requested. A
        /// requested capability may not immediately become active. Any requirements to activate the
        /// capability are returned in the <c>requirements</c> arrays.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public bool? Requested { get; set; }
    }
}
