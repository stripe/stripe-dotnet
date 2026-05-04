// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCapabilitiesCardPaymentsProtectionsPspMigrationOptions : INestedOptions
    {
        /// <summary>
        /// Passing true requests the protection.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
