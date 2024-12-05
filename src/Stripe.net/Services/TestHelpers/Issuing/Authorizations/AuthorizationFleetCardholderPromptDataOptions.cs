// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationFleetCardholderPromptDataOptions : INestedOptions
    {
        /// <summary>
        /// Driver ID.
        /// </summary>
        [JsonProperty("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// Odometer reading.
        /// </summary>
        [JsonProperty("odometer")]
        public long? Odometer { get; set; }

        /// <summary>
        /// An alphanumeric ID. This field is used when a vehicle ID, driver ID, or generic ID is
        /// entered by the cardholder, but the merchant or card network did not specify the prompt
        /// type.
        /// </summary>
        [JsonProperty("unspecified_id")]
        public string UnspecifiedId { get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Vehicle number.
        /// </summary>
        [JsonProperty("vehicle_number")]
        public string VehicleNumber { get; set; }
    }
}
