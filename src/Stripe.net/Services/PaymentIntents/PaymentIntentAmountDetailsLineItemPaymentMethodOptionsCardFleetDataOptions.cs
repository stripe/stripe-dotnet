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
        /// One of: <c>air_conditioning_service</c>, <c>alcohol</c>, <c>aviation_fuel_premium</c>,
        /// <c>aviation_fuel_regular</c>, <c>car_care_detailing</c>, <c>compressed_natural_gas</c>,
        /// <c>deli</c>, <c>food_service</c>, <c>green_gasoline_mid_plus</c>,
        /// <c>green_gasoline_premium_super</c>, <c>green_gasoline_regular</c>, <c>grocery</c>,
        /// <c>liquid_natural_gas</c>, <c>liquid_propane_gas</c>, <c>lodging</c>,
        /// <c>marine_diesel</c>, <c>marine_fuel</c>, <c>merchandise</c>, <c>mid_plus</c>,
        /// <c>mid_plus_ethanol</c>, <c>miscellaneous_aviation_products_services</c>,
        /// <c>miscellaneous_fuel</c>, <c>miscellaneous_marine_products_services</c>,
        /// <c>miscellaneous_vehicle_products_services</c>, <c>packaged_beverage</c>,
        /// <c>premium_diesel</c>, <c>premium_super</c>, <c>premium_super_ethanol</c>,
        /// <c>preventative_maintenance</c>, <c>regular</c>, <c>regular_diesel</c>,
        /// <c>regular_ethanol</c>, <c>repairs</c>, <c>self_service_car_wash</c>, <c>shower</c>,
        /// <c>store_service</c>, <c>tobacco</c>, <c>vehicle_accessories</c>,
        /// <c>vehicle_parking</c>, <c>vehicle_parts</c>, or <c>wash_out</c>.
        /// </summary>
        [JsonProperty("product_type")]
        [STJS.JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// The type of service received at the acceptor location.
        /// One of: <c>full_service</c>, <c>high_speed_diesel</c>, <c>non_fuel_only</c>, or
        /// <c>self_service</c>.
        /// </summary>
        [JsonProperty("service_type")]
        [STJS.JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
