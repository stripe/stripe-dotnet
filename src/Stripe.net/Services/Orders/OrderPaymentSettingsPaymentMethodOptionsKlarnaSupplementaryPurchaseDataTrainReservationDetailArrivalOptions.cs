// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailArrivalOptions : INestedOptions
    {
        /// <summary>
        /// Address of the arrival location.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailArrivalAddressOptions Address { get; set; }

        /// <summary>
        /// Identifier name or reference for the arrival location.
        /// </summary>
        [JsonProperty("arrival_location")]
        [STJS.JsonPropertyName("arrival_location")]
        public string ArrivalLocation { get; set; }
    }
}
