// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataRoundTripReservationDetailPassengerOptions : INestedOptions
    {
        /// <summary>
        /// The family name of the person.
        /// </summary>
        [JsonProperty("family_name")]
        [STJS.JsonPropertyName("family_name")]
        public string FamilyName { get; set; }

        /// <summary>
        /// The given name of the person.
        /// </summary>
        [JsonProperty("given_name")]
        [STJS.JsonPropertyName("given_name")]
        public string GivenName { get; set; }
    }
}
