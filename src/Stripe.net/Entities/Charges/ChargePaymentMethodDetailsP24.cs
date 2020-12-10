// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsP24 : StripeEntity<ChargePaymentMethodDetailsP24>
    {
        /// <summary>
        /// The customer's bank. Can be one of <c>ing</c>, <c>citi_handlowy</c>,
        /// <c>tmobile_usbugi_bankowe</c>, <c>plus_bank</c>, <c>etransfer_pocztowy24</c>,
        /// <c>banki_spbdzielcze</c>, <c>bank_nowy_bfg_sa</c>, <c>getin_bank</c>, <c>blik</c>,
        /// <c>noble_pay</c>, <c>ideabank</c>, <c>envelobank</c>, <c>santander_przelew24</c>,
        /// <c>nest_przelew</c>, <c>mbank_mtransfer</c>, <c>inteligo</c>, <c>pbac_z_ipko</c>,
        /// <c>bnp_paribas</c>, <c>credit_agricole</c>, <c>toyota_bank</c>, <c>bank_pekao_sa</c>,
        /// <c>volkswagen_bank</c>, <c>bank_millennium</c>, <c>alior_bank</c>, or <c>boz</c>.
        /// One of: <c>alior_bank</c>, <c>bank_millennium</c>, <c>bank_nowy_bfg_sa</c>,
        /// <c>bank_pekao_sa</c>, <c>banki_spbdzielcze</c>, <c>blik</c>, <c>bnp_paribas</c>,
        /// <c>boz</c>, <c>citi_handlowy</c>, <c>credit_agricole</c>, <c>envelobank</c>,
        /// <c>etransfer_pocztowy24</c>, <c>getin_bank</c>, <c>ideabank</c>, <c>ing</c>,
        /// <c>inteligo</c>, <c>mbank_mtransfer</c>, <c>nest_przelew</c>, <c>noble_pay</c>,
        /// <c>pbac_z_ipko</c>, <c>plus_bank</c>, <c>santander_przelew24</c>,
        /// <c>tmobile_usbugi_bankowe</c>, <c>toyota_bank</c>, or <c>volkswagen_bank</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }

        /// <summary>
        /// Unique reference for this Przelewy24 payment.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Przelewy24 directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// Przelewy24 rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
