// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardEvChargingOptions : INestedOptions
    {
        /// <summary>
        /// The carbon footprint avoided by the charging session, in grams of CO2.
        /// </summary>
        [JsonProperty("carbon_footprint_avoided_grams_co2")]
        [STJS.JsonPropertyName("carbon_footprint_avoided_grams_co2")]
        public long? CarbonFootprintAvoidedGramsCo2 { get; set; }

        /// <summary>
        /// The time the charging session ended, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("charging_ended_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("charging_ended_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ChargingEndedAt { get; set; }

        /// <summary>
        /// The power output capacity of the charging station, in kilowatts (kW).
        /// </summary>
        [JsonProperty("charging_power_output_capacity_kw")]
        [STJS.JsonPropertyName("charging_power_output_capacity_kw")]
        public long? ChargingPowerOutputCapacityKw { get; set; }

        /// <summary>
        /// The time the charging session started, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("charging_started_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("charging_started_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ChargingStartedAt { get; set; }

        /// <summary>
        /// The type of connector used for the charging session.
        /// One of: <c>ac_gb_t</c>, <c>ac_j1772</c>, <c>ac_mennekes</c>, <c>dc_ccs1</c>,
        /// <c>dc_ccs2</c>, <c>dc_chademo</c>, <c>dc_gb_t</c>, <c>dc_mcs</c>, or <c>nacs</c>.
        /// </summary>
        [JsonProperty("connector_type")]
        [STJS.JsonPropertyName("connector_type")]
        public string ConnectorType { get; set; }

        /// <summary>
        /// The estimated distance in kilometers or miles added to the vehicle during the charging
        /// session.
        /// </summary>
        [JsonProperty("estimated_range_added")]
        [STJS.JsonPropertyName("estimated_range_added")]
        public long? EstimatedRangeAdded { get; set; }

        /// <summary>
        /// The estimated distance in kilometers or miles remaining in the vehicle after the
        /// charging session.
        /// </summary>
        [JsonProperty("estimated_range_left")]
        [STJS.JsonPropertyName("estimated_range_left")]
        public long? EstimatedRangeLeft { get; set; }

        /// <summary>
        /// The maximum power dispensed during the charging session, in kilowatts (kW).
        /// </summary>
        [JsonProperty("maximum_power_dispensed_kw")]
        [STJS.JsonPropertyName("maximum_power_dispensed_kw")]
        public long? MaximumPowerDispensedKw { get; set; }
    }
}
