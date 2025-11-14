// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailArrivalOptions : INestedOptions
    {
        /// <summary>
        /// Address of the arrival location.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataTrainReservationDetailArrivalAddressOptions Address { get; set; }

        /// <summary>
        /// Identifier name or reference for the arrival location.
        /// </summary>
        [JsonProperty("arrival_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("arrival_location")]
#endif
        public string ArrivalLocation { get; set; }
    }
}
