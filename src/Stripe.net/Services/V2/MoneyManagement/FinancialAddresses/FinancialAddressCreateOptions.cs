// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCreateOptions : BaseOptions
    {
        /// <summary>
        /// Open Enum. The currency the FinancialAddress should support. Currently, only the
        /// <c>usd</c> and <c>gbp</c> values are supported.
        /// One of: <c>aed</c>, <c>afn</c>, <c>all</c>, <c>amd</c>, <c>ang</c>, <c>aoa</c>,
        /// <c>ars</c>, <c>aud</c>, <c>awg</c>, <c>azn</c>, <c>bam</c>, <c>bbd</c>, <c>bdt</c>,
        /// <c>bgn</c>, <c>bhd</c>, <c>bif</c>, <c>bmd</c>, <c>bnd</c>, <c>bob</c>, <c>bov</c>,
        /// <c>brl</c>, <c>bsd</c>, <c>btn</c>, <c>bwp</c>, <c>byn</c>, <c>byr</c>, <c>bzd</c>,
        /// <c>cad</c>, <c>cdf</c>, <c>che</c>, <c>chf</c>, <c>chw</c>, <c>clf</c>, <c>clp</c>,
        /// <c>cny</c>, <c>cop</c>, <c>cou</c>, <c>crc</c>, <c>cuc</c>, <c>cup</c>, <c>cve</c>,
        /// <c>czk</c>, <c>djf</c>, <c>dkk</c>, <c>dop</c>, <c>dzd</c>, <c>eek</c>, <c>egp</c>,
        /// <c>ern</c>, <c>etb</c>, <c>eur</c>, <c>fjd</c>, <c>fkp</c>, <c>gbp</c>, <c>gel</c>,
        /// <c>ghc</c>, <c>ghs</c>, <c>gip</c>, <c>gmd</c>, <c>gnf</c>, <c>gtq</c>, <c>gyd</c>,
        /// <c>hkd</c>, <c>hnl</c>, <c>hrk</c>, <c>htg</c>, <c>huf</c>, <c>idr</c>, <c>ils</c>,
        /// <c>inr</c>, <c>iqd</c>, <c>irr</c>, <c>isk</c>, <c>jmd</c>, <c>jod</c>, <c>jpy</c>,
        /// <c>kes</c>, <c>kgs</c>, <c>khr</c>, <c>kmf</c>, <c>kpw</c>, <c>krw</c>, <c>kwd</c>,
        /// <c>kyd</c>, <c>kzt</c>, <c>lak</c>, <c>lbp</c>, <c>lkr</c>, <c>lrd</c>, <c>lsl</c>,
        /// <c>ltl</c>, <c>lvl</c>, <c>lyd</c>, <c>mad</c>, <c>mdl</c>, <c>mga</c>, <c>mkd</c>,
        /// <c>mmk</c>, <c>mnt</c>, <c>mop</c>, <c>mro</c>, <c>mru</c>, <c>mur</c>, <c>mvr</c>,
        /// <c>mwk</c>, <c>mxn</c>, <c>mxv</c>, <c>myr</c>, <c>mzn</c>, <c>nad</c>, <c>ngn</c>,
        /// <c>nio</c>, <c>nok</c>, <c>npr</c>, <c>nzd</c>, <c>omr</c>, <c>pab</c>, <c>pen</c>,
        /// <c>pgk</c>, <c>php</c>, <c>pkr</c>, <c>pln</c>, <c>pyg</c>, <c>qar</c>, <c>ron</c>,
        /// <c>rsd</c>, <c>rub</c>, <c>rwf</c>, <c>sar</c>, <c>sbd</c>, <c>scr</c>, <c>sdg</c>,
        /// <c>sek</c>, <c>sgd</c>, <c>shp</c>, <c>sle</c>, <c>sll</c>, <c>sos</c>, <c>srd</c>,
        /// <c>ssp</c>, <c>std</c>, <c>stn</c>, <c>svc</c>, <c>syp</c>, <c>szl</c>, <c>thb</c>,
        /// <c>tjs</c>, <c>tmt</c>, <c>tnd</c>, <c>top</c>, <c>try</c>, <c>ttd</c>, <c>twd</c>,
        /// <c>tzs</c>, <c>uah</c>, <c>ugx</c>, <c>usd</c>, <c>usdb</c>, <c>usdc</c>, <c>usn</c>,
        /// <c>uyi</c>, <c>uyu</c>, <c>uzs</c>, <c>vef</c>, <c>ves</c>, <c>vnd</c>, <c>vuv</c>,
        /// <c>wst</c>, <c>xaf</c>, <c>xcd</c>, <c>xcg</c>, <c>xof</c>, <c>xpf</c>, <c>yer</c>,
        /// <c>zar</c>, <c>zmk</c>, <c>zmw</c>, <c>zwd</c>, <c>zwg</c>, or <c>zwl</c>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount the new FinancialAddress should be associated with.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }
    }
}
