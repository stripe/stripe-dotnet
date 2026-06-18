// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationRecipientCapabilitiesBankAccountsFpsProtectionsPspMigrationOptions : INestedOptions
    {
        /// <summary>
        /// To request a protection, pass true.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool? Requested { get; set; }
    }
}
