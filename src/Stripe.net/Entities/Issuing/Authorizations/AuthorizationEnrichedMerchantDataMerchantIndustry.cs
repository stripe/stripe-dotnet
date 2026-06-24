// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationEnrichedMerchantDataMerchantIndustry : StripeEntity<AuthorizationEnrichedMerchantDataMerchantIndustry>, IHasId
    {
        /// <summary>
        /// Most specific value of the seller's category.
        /// One of: <c>accessories</c>, <c>accounting_and_bookkeeping</c>, <c>acupuncture</c>,
        /// <c>administrative_services</c>, <c>adult_entertainment</c>, <c>adult_retail</c>,
        /// <c>advertising_and_marketing</c>, <c>advertising_technology</c>,
        /// <c>agricultural_technology</c>, <c>agriculture_and_forestry</c>,
        /// <c>airlines_and_aviation</c>, <c>alternative_medicine</c>, <c>alternative_rentals</c>,
        /// <c>anesthesiologists</c>, <c>antiques</c>, <c>aquatic_transportation</c>,
        /// <c>arcades_and_amusement_parks</c>, <c>art_dealers_and_galleries</c>,
        /// <c>arts_and_hobbies</c>, <c>atms</c>, <c>auctions</c>, <c>auto_parts_and_supplies</c>,
        /// <c>auto_smog_checks</c>, <c>auto_tires</c>, <c>auto_transmission</c>,
        /// <c>automotive_dealerships</c>, <c>automotive_retail</c>, <c>automotive_services</c>,
        /// <c>bakeries</c>, <c>banking_and_finance</c>, <c>bars</c>, <c>beauty_spas_and_salons</c>,
        /// <c>beer_wine_and_spirits</c>, <c>benefits</c>, <c>bicycles</c>,
        /// <c>billiards_and_pool</c>, <c>biotechnology</c>, <c>blood_banks_and_centers</c>,
        /// <c>boat_dealers</c>, <c>bookstores</c>, <c>bowling</c>,
        /// <c>breweries_distilleries_and_wineries</c>, <c>business_brokers_and_franchises</c>,
        /// <c>business_services</c>, <c>butchers</c>, <c>buy_now_pay_later</c>, <c>cafes</c>,
        /// <c>candy_shops</c>, <c>cannabis_dispensary</c>, <c>car_appraisers</c>,
        /// <c>car_wash_and_detail</c>, <c>cardiologists</c>, <c>cards_and_stationery</c>,
        /// <c>casinos_and_gambling</c>, <c>catering</c>, <c>charity</c>, <c>childcare</c>,
        /// <c>children_s_clothing</c>, <c>children_s_retail</c>, <c>chiropractors</c>,
        /// <c>circuses_and_carnivals</c>, <c>cleaning</c>, <c>clothing_and_accessories</c>,
        /// <c>clothing_services</c>, <c>commercial_supplies</c>, <c>communication_software</c>,
        /// <c>computers_and_electronics</c>, <c>construction_and_home_improvement</c>,
        /// <c>construction_supplies</c>, <c>contractors</c>, <c>convenience_stores</c>,
        /// <c>cosmetics</c>, <c>costumes</c>, <c>counseling_and_therapy</c>, <c>couriers</c>,
        /// <c>coworking_spaces</c>, <c>creative</c>, <c>creative_software</c>,
        /// <c>credit_reporting</c>, <c>crm</c>, <c>crowdfunding</c>, <c>cryptocurrency</c>,
        /// <c>dance_halls_and_saloons</c>, <c>delivery_services</c>, <c>dentists</c>,
        /// <c>department_stores</c>, <c>dermatologists</c>, <c>design_technology</c>,
        /// <c>developer_tools</c>, <c>digital_money_movement</c>, <c>discount_stores</c>,
        /// <c>education</c>, <c>educational_technology</c>, <c>electric_vehicle_charging</c>,
        /// <c>emergency_services</c>, <c>employment_services</c>, <c>enterprise_software</c>,
        /// <c>entertainment</c>, <c>ents</c>, <c>environmental_technology</c>,
        /// <c>equipment_rentals</c>, <c>events_and_event_planning</c>, <c>eyewear</c>,
        /// <c>fairgrounds_and_rodeos</c>, <c>family_medicine</c>, <c>fast_food</c>,
        /// <c>fertility</c>, <c>financial_management_software</c>,
        /// <c>financial_planning_and_investments</c>, <c>financial_technology</c>,
        /// <c>fishmongers</c>, <c>flea_markets</c>, <c>fleet</c>, <c>florists</c>,
        /// <c>food_and_drink</c>, <c>food_delivery_services</c>, <c>food_trucks</c>,
        /// <c>fuel_dealers</c>, <c>funeral_services</c>, <c>furniture</c>, <c>gas_stations</c>,
        /// <c>gastroenterologists</c>, <c>general_goods</c>, <c>general_surgery</c>,
        /// <c>gift_and_novelty</c>, <c>government</c>, <c>grocery_delivery_services</c>,
        /// <c>gyms_health_and_fitness_centers</c>, <c>hair_removal</c>,
        /// <c>hair_salons_and_barbers</c>, <c>hardware</c>, <c>hardware_and_home_improvement</c>,
        /// <c>hospitals_clinics_and_medical_centers</c>, <c>household_services</c>,
        /// <c>hr_platform</c>, <c>immigration</c>, <c>import_and_export</c>,
        /// <c>industrial_and_energy</c>, <c>inflight_internet_and_entertainment</c>,
        /// <c>insurance</c>, <c>internal_medicine</c>, <c>internet</c>, <c>jewelry_and_watches</c>,
        /// <c>landmarks</c>, <c>laundry_and_garment_services</c>, <c>lawn_and_garden</c>,
        /// <c>legal_services</c>, <c>legal_technology</c>, <c>lending</c>, <c>lingerie</c>,
        /// <c>lodging</c>, <c>luggage</c>, <c>maintenance_and_repair</c>,
        /// <c>manicures_and_pedicures</c>, <c>manufacturing</c>, <c>marina</c>,
        /// <c>marine_supplies</c>, <c>marketing_software</c>,
        /// <c>massage_clinics_and_therapists</c>, <c>media</c>,
        /// <c>medical_and_healthcare_services</c>, <c>medical_supplies_and_labs</c>,
        /// <c>men_s_clothing</c>, <c>mental_health_professionals</c>, <c>mobile_applications</c>,
        /// <c>motorcycle_moped_and_scooter_repair</c>, <c>museums</c>, <c>musical_instruments</c>,
        /// <c>neurologists</c>, <c>news_and_magazines</c>, <c>newsstands</c>, <c>nutritionists</c>,
        /// <c>obstetricians_and_gynecologists</c>, <c>office_supplies</c>, <c>oil_and_gas</c>,
        /// <c>oncologists</c>, <c>online_marketplace</c>, <c>ophthalmologists</c>,
        /// <c>optometrists</c>, <c>organizations</c>, <c>orthopedic_surgeons</c>, <c>other</c>,
        /// <c>outlets</c>, <c>packaging</c>, <c>paper</c>, <c>parking</c>,
        /// <c>parks_and_outdoors</c>, <c>party_centers</c>, <c>pathologists</c>, <c>pawn_shops</c>,
        /// <c>pediatricians</c>, <c>pet_grooming</c>, <c>pet_services</c>, <c>pets</c>,
        /// <c>pharmacies</c>, <c>photography</c>, <c>physical_therapy</c>, <c>piercings</c>,
        /// <c>plastic_surgeons</c>, <c>podiatrists</c>, <c>pregnancy_and_sexual_health</c>,
        /// <c>professional_services</c>, <c>property_management</c>, <c>psychiatrists</c>,
        /// <c>psychics_and_astrologers</c>, <c>psychologists</c>, <c>public_services</c>,
        /// <c>public_transportation</c>, <c>publishing_software</c>, <c>radiologists</c>,
        /// <c>rails</c>, <c>real_estate</c>, <c>recreation</c>, <c>religious</c>,
        /// <c>renewable_energy</c>, <c>respiratory</c>, <c>restaurants</c>, <c>retail</c>,
        /// <c>ride_shares</c>, <c>sales_enablement_software</c>, <c>security_and_privacy</c>,
        /// <c>security_and_safety</c>, <c>services</c>, <c>shipping_and_freight</c>, <c>shoes</c>,
        /// <c>skin_care</c>, <c>social_clubs</c>, <c>software</c>, <c>software_engineering</c>,
        /// <c>spas</c>, <c>specialist_physicans</c>, <c>specialty_clothing_and_accessories</c>,
        /// <c>specialty_foods</c>, <c>specialty_groceries</c>, <c>specialty_retail</c>,
        /// <c>sporting_goods</c>, <c>storage</c>, <c>streaming_services</c>,
        /// <c>supermarkets_and_grocery_stores</c>, <c>swimwear</c>, <c>tailors</c>,
        /// <c>tanning_salons</c>, <c>tattoos</c>, <c>taxes</c>, <c>taxi_and_limousines</c>,
        /// <c>technology</c>, <c>telecommunications</c>, <c>television</c>, <c>textiles</c>,
        /// <c>theater_and_cinema</c>, <c>tickets_and_reservations</c>,
        /// <c>tobacco_smoke_and_vape_shops</c>, <c>tolls_and_fees</c>,
        /// <c>tourist_information_and_services</c>, <c>towing_and_roadside_assistance</c>,
        /// <c>toy_stores</c>, <c>transportation</c>, <c>travel</c>, <c>travel_services</c>,
        /// <c>travel_software</c>, <c>urologists</c>, <c>utilities</c>, <c>vehicle_rentals</c>,
        /// <c>vending_machine</c>, <c>venues</c>, <c>veterinarians</c>, <c>video_games</c>,
        /// <c>vintage_and_thrift</c>, <c>warehouses_and_wholesale_stores</c>,
        /// <c>water_and_waste_management_services</c>, <c>web_infrastructure</c>,
        /// <c>wedding_and_bridal</c>, <c>women_s_clothing</c>, or <c>zoos_and_aquariums</c>.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Increasingly specific textual representations of the seller's category.
        /// </summary>
        [JsonProperty("names")]
        [STJS.JsonPropertyName("names")]
        public List<string> Names { get; set; }
    }
}
