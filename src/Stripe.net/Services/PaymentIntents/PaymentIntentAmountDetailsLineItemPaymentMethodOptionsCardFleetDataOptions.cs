// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardFleetDataOptions : INestedOptions
    {
        /// <summary>
        /// The type of product being purchased at this line item.
        /// One of: <c>additive_dosage</c>, <c>additized_diesel_2</c>, <c>additized_diesel_3</c>,
        /// <c>air_conditioning_service</c>, <c>air_filter</c>, <c>alcohol</c>, <c>antifreeze</c>,
        /// <c>automotive_merchandise</c>, <c>aviation_fuel_premium</c>,
        /// <c>aviation_fuel_regular</c>, <c>batteries</c>, <c>biodiesel_b1</c>,
        /// <c>biodiesel_b10</c>, <c>biodiesel_b100</c>, <c>biodiesel_b11</c>, <c>biodiesel_b15</c>,
        /// <c>biodiesel_b2</c>, <c>biodiesel_b20</c>, <c>biodiesel_b5</c>, <c>biodiesel_b75</c>,
        /// <c>biodiesel_b99</c>, <c>blended_diesel_1_and_2</c>, <c>body_work</c>,
        /// <c>brake_fluid</c>, <c>brake_service</c>, <c>car_care_detailing</c>, <c>car_wash</c>,
        /// <c>compressed_natural_gas</c>, <c>def_at_pump</c>, <c>deli</c>, <c>e85</c>,
        /// <c>engine_service</c>, <c>ethanol_e16_to_e84</c>, <c>ev_battery_exchanges</c>,
        /// <c>ev_charging_fee</c>, <c>evc_level_1</c>, <c>evc_level_2</c>, <c>evc_level_3</c>,
        /// <c>evc_level_4</c>, <c>evc_level_5</c>, <c>exhaust_service</c>,
        /// <c>federal_tire_excise_tax</c>, <c>food_service</c>, <c>fuel_additive_treatment</c>,
        /// <c>fuel_system</c>, <c>green_gasoline_mid_plus</c>, <c>green_gasoline_premium_super</c>,
        /// <c>green_gasoline_regular</c>, <c>grocery</c>, <c>heating_oil</c>, <c>hoses</c>,
        /// <c>hydrogen_h35</c>, <c>hydrogen_h70</c>, <c>inspection</c>, <c>kerosene_low_sulfur</c>,
        /// <c>kerosene_low_sulfur_non_taxable</c>, <c>kerosene_ultra_low_sulfur</c>,
        /// <c>kerosene_ultra_low_sulfur_non_taxable</c>, <c>labor</c>, <c>lamps</c>,
        /// <c>liquid_natural_gas</c>, <c>liquid_propane_gas</c>, <c>lodging</c>,
        /// <c>low_octane_unleaded</c>, <c>lube</c>, <c>marine_diesel</c>, <c>marine_fuel</c>,
        /// <c>marine_fuel_1</c>, <c>marine_fuel_2</c>, <c>marine_fuel_3</c>, <c>marine_fuel_4</c>,
        /// <c>marine_fuel_5</c>, <c>marine_other</c>, <c>merchandise</c>, <c>mid_plus</c>,
        /// <c>mid_plus_2</c>, <c>mid_plus_2_10</c>, <c>mid_plus_2_e15</c>,
        /// <c>mid_plus_2_reformulated</c>, <c>mid_plus_e10</c>, <c>mid_plus_e15</c>,
        /// <c>mid_plus_ethanol</c>, <c>mid_plus_reformulated</c>,
        /// <c>miscellaneous_aviation_products_services</c>, <c>miscellaneous_fuel</c>,
        /// <c>miscellaneous_marine_products_services</c>,
        /// <c>miscellaneous_vehicle_products_services</c>, <c>motor_oil</c>, <c>off_road_b1</c>,
        /// <c>off_road_b10</c>, <c>off_road_b100</c>, <c>off_road_b11</c>, <c>off_road_b15</c>,
        /// <c>off_road_b2</c>, <c>off_road_b20</c>, <c>off_road_b5</c>, <c>off_road_b75</c>,
        /// <c>off_road_b99</c>, <c>off_road_biodiesel</c>, <c>off_road_diesel_1</c>,
        /// <c>off_road_diesel_2</c>, <c>off_road_mid_plus</c>, <c>off_road_mid_plus_2</c>,
        /// <c>off_road_premium_diesel_1</c>, <c>off_road_premium_diesel_2</c>,
        /// <c>off_road_premium_super</c>, <c>off_road_premium_super_2</c>, <c>off_road_regular</c>,
        /// <c>off_road_renewable_diesel_b6_to_b20</c>, <c>off_road_renewable_diesel_r95</c>,
        /// <c>oil_change</c>, <c>oil_filter</c>, <c>other_lubricants</c>, <c>packaged_beverage</c>,
        /// <c>premium_diesel</c>, <c>premium_diesel_2</c>, <c>premium_diesel_b20_plus</c>,
        /// <c>premium_diesel_under_b20</c>, <c>premium_super</c>, <c>premium_super_2</c>,
        /// <c>premium_super_2_10</c>, <c>premium_super_2_e15</c>,
        /// <c>premium_super_2_reformulated</c>, <c>premium_super_e10</c>, <c>premium_super_e15</c>,
        /// <c>premium_super_ethanol</c>, <c>premium_super_reformulated</c>,
        /// <c>preventative_maintenance</c>, <c>racing_fuel</c>, <c>recreational_fuel_90_octane</c>,
        /// <c>regular</c>, <c>regular_diesel</c>, <c>regular_diesel_2</c>, <c>regular_e10</c>,
        /// <c>regular_e15</c>, <c>regular_ethanol</c>, <c>regular_reformulated</c>,
        /// <c>renewable_diesel_b6_to_b20</c>, <c>renewable_diesel_r95</c>, <c>repairs</c>,
        /// <c>road_service</c>, <c>rv_dump_fee</c>, <c>scales</c>, <c>self_service_car_wash</c>,
        /// <c>service_package</c>, <c>shower</c>, <c>store_service</c>, <c>synthetic_oil</c>,
        /// <c>tire_related</c>, <c>tire_repair</c>, <c>tire_rotation</c>, <c>tires</c>,
        /// <c>tobacco</c>, <c>toll_payments</c>, <c>towing</c>, <c>trailer_wash</c>,
        /// <c>transmission_service</c>, <c>truck_tank_cleaning</c>, <c>vehicle_accessories</c>,
        /// <c>vehicle_glass</c>, <c>vehicle_parking</c>, <c>vehicle_parts</c>, <c>vehicle_prep</c>,
        /// <c>vehicle_rental</c>, <c>vehicle_work_order</c>, <c>wash_out</c>, <c>washer_fluid</c>,
        /// <c>white_gas</c>, or <c>wipers</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("product_type")]
        [STJS.JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// The type of service received at the acceptor location.
        /// One of: <c>full_service</c>, <c>high_speed_diesel</c>, <c>non_fuel_only</c>, or
        /// <c>self_service</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("service_type")]
        [STJS.JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
