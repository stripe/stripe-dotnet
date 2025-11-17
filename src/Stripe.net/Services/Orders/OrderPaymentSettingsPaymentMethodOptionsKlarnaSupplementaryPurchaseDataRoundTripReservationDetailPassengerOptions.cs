// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailPassengerOptions : INestedOptions
    {
        /// <summary>
        /// The family name of the person.
        /// </summary>
        [JsonProperty("family_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("family_name")]
#endif
        public string FamilyName { get; set; }

        /// <summary>
        /// The given name of the person.
        /// </summary>
        [JsonProperty("given_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
#endif
        public string GivenName { get; set; }
    }
}
