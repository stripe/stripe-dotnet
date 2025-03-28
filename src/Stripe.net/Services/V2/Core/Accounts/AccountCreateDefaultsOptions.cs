// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateDefaultsOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
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
        /// <c>tzs</c>, <c>uah</c>, <c>ugx</c>, <c>usd</c>, <c>usdc</c>, <c>usn</c>, <c>uyi</c>,
        /// <c>uyu</c>, <c>uzs</c>, <c>vef</c>, <c>ves</c>, <c>vnd</c>, <c>vuv</c>, <c>wst</c>,
        /// <c>xaf</c>, <c>xcd</c>, <c>xcg</c>, <c>xof</c>, <c>xpf</c>, <c>yer</c>, <c>zar</c>,
        /// <c>zmk</c>, <c>zmw</c>, <c>zwd</c>, <c>zwg</c>, or <c>zwl</c>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The Account's preferred locales (languages), ordered by preference.
        /// One of: <c>ar-SA</c>, <c>bg</c>, <c>bg-BG</c>, <c>cs</c>, <c>cs-CZ</c>, <c>da</c>,
        /// <c>da-DK</c>, <c>de</c>, <c>de-DE</c>, <c>el</c>, <c>el-GR</c>, <c>en</c>, <c>en-AU</c>,
        /// <c>en-CA</c>, <c>en-GB</c>, <c>en-IE</c>, <c>en-IN</c>, <c>en-NZ</c>, <c>en-SG</c>,
        /// <c>en-US</c>, <c>es</c>, <c>es-419</c>, <c>es-ES</c>, <c>et</c>, <c>et-EE</c>,
        /// <c>fi</c>, <c>fil</c>, <c>fil-PH</c>, <c>fi-FI</c>, <c>fr</c>, <c>fr-CA</c>,
        /// <c>fr-FR</c>, <c>he-IL</c>, <c>hr</c>, <c>hr-HR</c>, <c>hu</c>, <c>hu-HU</c>, <c>id</c>,
        /// <c>id-ID</c>, <c>it</c>, <c>it-IT</c>, <c>ja</c>, <c>ja-JP</c>, <c>ko</c>, <c>ko-KR</c>,
        /// <c>lt</c>, <c>lt-LT</c>, <c>lv</c>, <c>lv-LV</c>, <c>ms</c>, <c>ms-MY</c>, <c>mt</c>,
        /// <c>mt-MT</c>, <c>nb</c>, <c>nb-NO</c>, <c>nl</c>, <c>nl-NL</c>, <c>pl</c>, <c>pl-PL</c>,
        /// <c>pt</c>, <c>pt-BR</c>, <c>pt-PT</c>, <c>ro</c>, <c>ro-RO</c>, <c>ru</c>, <c>ru-RU</c>,
        /// <c>sk</c>, <c>sk-SK</c>, <c>sl</c>, <c>sl-SI</c>, <c>sv</c>, <c>sv-SE</c>, <c>th</c>,
        /// <c>th-TH</c>, <c>tr</c>, <c>tr-TR</c>, <c>vi</c>, <c>vi-VN</c>, <c>zh</c>,
        /// <c>zh-Hans</c>, <c>zh-Hant-HK</c>, <c>zh-Hant-TW</c>, <c>zh-HK</c>, or <c>zh-TW</c>.
        /// </summary>
        [JsonProperty("locales")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("locales")]
#endif
        public List<string> Locales { get; set; }

        /// <summary>
        /// Default responsibilities held by either Stripe or the platform.
        /// </summary>
        [JsonProperty("responsibilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("responsibilities")]
#endif
        public AccountCreateDefaultsResponsibilitiesOptions Responsibilities { get; set; }
    }
}
