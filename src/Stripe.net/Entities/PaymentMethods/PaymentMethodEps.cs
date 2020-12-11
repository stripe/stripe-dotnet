// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodEps : StripeEntity<PaymentMethodEps>
    {
        /// <summary>
        /// The customer's bank. Should be one of <c>arzte_und_apotheker_bank</c>,
        /// <c>austrian_anadi_bank_ag</c>, <c>bank_austria</c>, <c>bankhaus_carl_spangler</c>,
        /// <c>bankhaus_schelhammer_und_schattera_ag</c>, <c>bawag_psk_ag</c>, <c>bks_bank_ag</c>,
        /// <c>brull_kallmus_bank_ag</c>, <c>btv_vier_lander_bank</c>,
        /// <c>capital_bank_grawe_gruppe_ag</c>, <c>dolomitenbank</c>, <c>easybank_ag</c>,
        /// <c>erste_bank_und_sparkassen</c>, <c>hypo_alpeadriabank_international_ag</c>,
        /// <c>hypo_noe_lb_fur_niederosterreich_u_wien</c>,
        /// <c>hypo_oberosterreich_salzburg_steiermark</c>, <c>hypo_tirol_bank_ag</c>,
        /// <c>hypo_vorarlberg_bank_ag</c>, <c>hypo_bank_burgenland_aktiengesellschaft</c>,
        /// <c>marchfelder_bank</c>, <c>oberbank_ag</c>, <c>raiffeisen_bankengruppe_osterreich</c>,
        /// <c>schoellerbank_ag</c>, <c>sparda_bank_wien</c>, <c>volksbank_gruppe</c>,
        /// <c>volkskreditbank_ag</c>, or <c>vr_bank_braunau</c>.
        /// One of: <c>arzte_und_apotheker_bank</c>, <c>austrian_anadi_bank_ag</c>,
        /// <c>bank_austria</c>, <c>bankhaus_carl_spangler</c>,
        /// <c>bankhaus_schelhammer_und_schattera_ag</c>, <c>bawag_psk_ag</c>, <c>bks_bank_ag</c>,
        /// <c>brull_kallmus_bank_ag</c>, <c>btv_vier_lander_bank</c>,
        /// <c>capital_bank_grawe_gruppe_ag</c>, <c>dolomitenbank</c>, <c>easybank_ag</c>,
        /// <c>erste_bank_und_sparkassen</c>, <c>hypo_alpeadriabank_international_ag</c>,
        /// <c>hypo_bank_burgenland_aktiengesellschaft</c>,
        /// <c>hypo_noe_lb_fur_niederosterreich_u_wien</c>,
        /// <c>hypo_oberosterreich_salzburg_steiermark</c>, <c>hypo_tirol_bank_ag</c>,
        /// <c>hypo_vorarlberg_bank_ag</c>, <c>marchfelder_bank</c>, <c>oberbank_ag</c>,
        /// <c>raiffeisen_bankengruppe_osterreich</c>, <c>schoellerbank_ag</c>,
        /// <c>sparda_bank_wien</c>, <c>volksbank_gruppe</c>, <c>volkskreditbank_ag</c>, or
        /// <c>vr_bank_braunau</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
