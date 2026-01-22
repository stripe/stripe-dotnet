// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumVehicle : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumVehicle>
    {
        /// <summary>
        /// Make of the vehicle.
        /// </summary>
        [JsonProperty("make")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("make")]
#endif
        public string Make { get; set; }

        /// <summary>
        /// Model of the vehicle.
        /// </summary>
        [JsonProperty("model")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("model")]
#endif
        public string Model { get; set; }

        /// <summary>
        /// Odometer reading.
        /// </summary>
        [JsonProperty("odometer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("odometer")]
#endif
        public long Odometer { get; set; }

        /// <summary>
        /// Type of the vehicle.
        /// One of: <c>cargo_van</c>, <c>compact</c>, <c>economy</c>, <c>exotic</c>,
        /// <c>exotic_suv</c>, <c>fifteen_passenger_van</c>, <c>four_wheel_drive</c>,
        /// <c>full_size</c>, <c>intermediate</c>, <c>large_suv</c>, <c>large_truck</c>,
        /// <c>luxury</c>, <c>medium_suv</c>, <c>midsize</c>, <c>mini</c>, <c>minivan</c>,
        /// <c>miscellaneous</c>, <c>moped</c>, <c>moving_van</c>, <c>premium</c>, <c>regular</c>,
        /// <c>small_medium_truck</c>, <c>small_suv</c>, <c>special</c>, <c>standard</c>,
        /// <c>stretch</c>, <c>subcompact</c>, <c>taxi</c>, <c>twelve_foot_truck</c>,
        /// <c>twelve_passenger_van</c>, <c>twenty_foot_truck</c>, <c>twenty_four_foot_truck</c>,
        /// <c>twenty_six_foot_truck</c>, or <c>unique</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Class of the vehicle.
        /// One of: <c>business</c>, <c>economy</c>, <c>first_class</c>, or <c>premium_economy</c>.
        /// </summary>
        [JsonProperty("vehicle_class")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vehicle_class")]
#endif
        public string VehicleClass { get; set; }

        /// <summary>
        /// Vehicle identification number.
        /// </summary>
        [JsonProperty("vehicle_identification_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("vehicle_identification_number")]
#endif
        public string VehicleIdentificationNumber { get; set; }
    }
}
