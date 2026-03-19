// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationFleetCardholderPromptData : StripeEntity<AuthorizationFleetCardholderPromptData>
    {
        /// <summary>
        /// [Deprecated] An alphanumeric ID, though typical point of sales only support numeric
        /// entry. The card program can be configured to prompt for a vehicle ID, driver ID, or
        /// generic ID.
        /// </summary>
        [Obsolete("This property is deprecated, please refer to the description for details.")]
        [JsonProperty("alphanumeric_id")]
        [STJS.JsonPropertyName("alphanumeric_id")]
        public string AlphanumericId { get; set; }

        /// <summary>
        /// Driver ID.
        /// </summary>
        [JsonProperty("driver_id")]
        [STJS.JsonPropertyName("driver_id")]
        public string DriverId { get; set; }

        /// <summary>
        /// Odometer reading.
        /// </summary>
        [JsonProperty("odometer")]
        [STJS.JsonPropertyName("odometer")]
        public long? Odometer { get; set; }

        /// <summary>
        /// An alphanumeric ID. This field is used when a vehicle ID, driver ID, or generic ID is
        /// entered by the cardholder, but the merchant or card network did not specify the prompt
        /// type.
        /// </summary>
        [JsonProperty("unspecified_id")]
        [STJS.JsonPropertyName("unspecified_id")]
        public string UnspecifiedId { get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("user_id")]
        [STJS.JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Vehicle number.
        /// </summary>
        [JsonProperty("vehicle_number")]
        [STJS.JsonPropertyName("vehicle_number")]
        public string VehicleNumber { get; set; }
    }
}
