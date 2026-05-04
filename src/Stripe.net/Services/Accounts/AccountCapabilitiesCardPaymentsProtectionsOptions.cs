// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCapabilitiesCardPaymentsProtectionsOptions : INestedOptions
    {
        /// <summary>
        /// Protection for connected accounts migrating from another PSP.
        /// </summary>
        [JsonProperty("psp_migration")]
        [STJS.JsonPropertyName("psp_migration")]
        public AccountCapabilitiesCardPaymentsProtectionsPspMigrationOptions PspMigration { get; set; }
    }
}
