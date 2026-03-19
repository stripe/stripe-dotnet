// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCapabilitiesSofortPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Passing true requests the capability for the account, if it is not already requested. A
        /// requested capability may not immediately become active. Any requirements to activate the
        /// capability are returned in the <c>requirements</c> arrays.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
