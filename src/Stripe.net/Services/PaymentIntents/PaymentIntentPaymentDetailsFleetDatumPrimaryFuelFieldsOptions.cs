// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsFleetDatumPrimaryFuelFieldsOptions : INestedOptions
    {
        /// <summary>
        /// The fuel brand.
        /// One of: <c>aafes</c>, <c>amerada_hess</c>, <c>amoco_canada</c>,
        /// <c>amoco_petroleum_products</c>, <c>arco_products</c>, <c>asda</c>, <c>ashland_oil</c>,
        /// <c>bfl</c>, <c>bp_mobil</c>, <c>bp_oil</c>, <c>burrnah_major</c>, <c>butler_arndale</c>,
        /// <c>canadian_tire</c>, <c>canadian_turbo</c>, <c>caseys_general_store</c>, <c>cenex</c>,
        /// <c>chevron_canada</c>, <c>chevron_usa</c>, <c>circle_k_stores</c>,
        /// <c>citgo_petroleum</c>, <c>clark_brands</c>, <c>conoco_canada</c>, <c>conoco_inc</c>,
        /// <c>crown_central_petroleum</c>, <c>diamond_shamrock_inc</c>, <c>discount_tire</c>,
        /// <c>domo_gas</c>, <c>elf</c>, <c>erickson_oil</c>, <c>esso</c>, <c>esso_canada</c>,
        /// <c>exxon</c>, <c>exxonmobil</c>, <c>family_express</c>, <c>fas_gas_oil</c>,
        /// <c>federated_coop_sonic</c>, <c>fina</c>, <c>fina_inc</c>, <c>fkg_oil</c>, <c>flare</c>,
        /// <c>flying_j_inc</c>, <c>gas_america</c>, <c>gate_petroleum</c>, <c>getty_petroleum</c>,
        /// <c>giant_eagle</c>, <c>grow_mark_inc</c>, <c>gulf</c>, <c>gulf_canada</c>,
        /// <c>gulf_chevron</c>, <c>handy_way_food</c>, <c>heron</c>, <c>holiday_stores</c>,
        /// <c>home_depot</c>, <c>husky</c>, <c>hyvees</c>, <c>irving</c>, <c>irving_oil</c>,
        /// <c>j_sainsbury</c>, <c>jet_conoco</c>, <c>krogers</c>, <c>kuwait</c>,
        /// <c>kwik_trip_inc</c>, <c>lassus</c>, <c>loves_country_stores</c>,
        /// <c>mapco_express_inc</c>, <c>marathon_oil</c>, <c>martin_bailey_inc_dba_hucks</c>,
        /// <c>maxol</c>, <c>meineke</c>, <c>mfa</c>, <c>mohawk</c>, <c>mr_gas</c>, <c>murco</c>,
        /// <c>murphy_oil_canada</c>, <c>murphy_oil_usa_inc</c>, <c>nexcom</c>,
        /// <c>nordstrom_oil</c>, <c>olco</c>, <c>pdq_store</c>, <c>pennzoil_products_inc</c>,
        /// <c>petro</c>, <c>petro_canada</c>, <c>petro_t</c>, <c>phillips</c>, <c>pilot</c>,
        /// <c>pioneer</c>, <c>pure_oil</c>, <c>quaker_state</c>, <c>quarles_oil</c>,
        /// <c>quiktrip</c>, <c>racetrac_petroleum_inc</c>, <c>raceway_petroleum</c>, <c>repsol</c>,
        /// <c>rudy</c>, <c>safeway</c>, <c>seven_eleven</c>, <c>sheetz</c>, <c>shell</c>,
        /// <c>shell_canada</c>, <c>shell_oil</c>, <c>sinclair_oil</c>, <c>southland_oil</c>,
        /// <c>spar</c>, <c>speedway</c>, <c>sun_company_inc</c>, <c>suncor_sunoco_canada</c>,
        /// <c>tempo</c>, <c>tesco</c>, <c>tesoro_alaska</c>, <c>texaco</c>, <c>the_pantry_inc</c>,
        /// <c>thornton_oil</c>, <c>tosco</c>, <c>total</c>, <c>travel_centers_of_america</c>,
        /// <c>uk</c>, <c>ultramar_canada</c>, <c>unbranded_or_unassigned</c>,
        /// <c>unbranded_unassigned</c>, <c>union_76</c>, <c>united_dairy_farmer</c>,
        /// <c>united_refining_kwikfill</c>, <c>us_oil</c>, <c>usa_petroleum</c>, <c>valvoline</c>,
        /// <c>vg</c>, <c>w_morrison</c>, <c>warren_equities</c>, <c>wawa</c>,
        /// <c>western_energetix</c>, <c>wilco</c>, or <c>zions</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }
    }
}
