// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkShippingAddressCollectionOptions : INestedOptions
    {
        /// <summary>
        /// An array of two-letter ISO country codes representing which countries Checkout should
        /// provide as options for shipping locations. Unsupported country codes: <c>AS, CX, CC, CU,
        /// HM, IR, KP, MH, FM, NF, MP, PW, SD, SY, UM, VI</c>.
        /// One of: <c>AC</c>, <c>AD</c>, <c>AE</c>, <c>AF</c>, <c>AG</c>, <c>AI</c>, <c>AL</c>,
        /// <c>AM</c>, <c>AO</c>, <c>AQ</c>, <c>AR</c>, <c>AT</c>, <c>AU</c>, <c>AW</c>, <c>AX</c>,
        /// <c>AZ</c>, <c>BA</c>, <c>BB</c>, <c>BD</c>, <c>BE</c>, <c>BF</c>, <c>BG</c>, <c>BH</c>,
        /// <c>BI</c>, <c>BJ</c>, <c>BL</c>, <c>BM</c>, <c>BN</c>, <c>BO</c>, <c>BQ</c>, <c>BR</c>,
        /// <c>BS</c>, <c>BT</c>, <c>BV</c>, <c>BW</c>, <c>BY</c>, <c>BZ</c>, <c>CA</c>, <c>CD</c>,
        /// <c>CF</c>, <c>CG</c>, <c>CH</c>, <c>CI</c>, <c>CK</c>, <c>CL</c>, <c>CM</c>, <c>CN</c>,
        /// <c>CO</c>, <c>CR</c>, <c>CV</c>, <c>CW</c>, <c>CY</c>, <c>CZ</c>, <c>DE</c>, <c>DJ</c>,
        /// <c>DK</c>, <c>DM</c>, <c>DO</c>, <c>DZ</c>, <c>EC</c>, <c>EE</c>, <c>EG</c>, <c>EH</c>,
        /// <c>ER</c>, <c>ES</c>, <c>ET</c>, <c>FI</c>, <c>FJ</c>, <c>FK</c>, <c>FO</c>, <c>FR</c>,
        /// <c>GA</c>, <c>GB</c>, <c>GD</c>, <c>GE</c>, <c>GF</c>, <c>GG</c>, <c>GH</c>, <c>GI</c>,
        /// <c>GL</c>, <c>GM</c>, <c>GN</c>, <c>GP</c>, <c>GQ</c>, <c>GR</c>, <c>GS</c>, <c>GT</c>,
        /// <c>GU</c>, <c>GW</c>, <c>GY</c>, <c>HK</c>, <c>HN</c>, <c>HR</c>, <c>HT</c>, <c>HU</c>,
        /// <c>ID</c>, <c>IE</c>, <c>IL</c>, <c>IM</c>, <c>IN</c>, <c>IO</c>, <c>IQ</c>, <c>IS</c>,
        /// <c>IT</c>, <c>JE</c>, <c>JM</c>, <c>JO</c>, <c>JP</c>, <c>KE</c>, <c>KG</c>, <c>KH</c>,
        /// <c>KI</c>, <c>KM</c>, <c>KN</c>, <c>KR</c>, <c>KW</c>, <c>KY</c>, <c>KZ</c>, <c>LA</c>,
        /// <c>LB</c>, <c>LC</c>, <c>LI</c>, <c>LK</c>, <c>LR</c>, <c>LS</c>, <c>LT</c>, <c>LU</c>,
        /// <c>LV</c>, <c>LY</c>, <c>MA</c>, <c>MC</c>, <c>MD</c>, <c>ME</c>, <c>MF</c>, <c>MG</c>,
        /// <c>MK</c>, <c>ML</c>, <c>MM</c>, <c>MN</c>, <c>MO</c>, <c>MQ</c>, <c>MR</c>, <c>MS</c>,
        /// <c>MT</c>, <c>MU</c>, <c>MV</c>, <c>MW</c>, <c>MX</c>, <c>MY</c>, <c>MZ</c>, <c>NA</c>,
        /// <c>NC</c>, <c>NE</c>, <c>NG</c>, <c>NI</c>, <c>NL</c>, <c>NO</c>, <c>NP</c>, <c>NR</c>,
        /// <c>NU</c>, <c>NZ</c>, <c>OM</c>, <c>PA</c>, <c>PE</c>, <c>PF</c>, <c>PG</c>, <c>PH</c>,
        /// <c>PK</c>, <c>PL</c>, <c>PM</c>, <c>PN</c>, <c>PR</c>, <c>PS</c>, <c>PT</c>, <c>PY</c>,
        /// <c>QA</c>, <c>RE</c>, <c>RO</c>, <c>RS</c>, <c>RU</c>, <c>RW</c>, <c>SA</c>, <c>SB</c>,
        /// <c>SC</c>, <c>SE</c>, <c>SG</c>, <c>SH</c>, <c>SI</c>, <c>SJ</c>, <c>SK</c>, <c>SL</c>,
        /// <c>SM</c>, <c>SN</c>, <c>SO</c>, <c>SR</c>, <c>SS</c>, <c>ST</c>, <c>SV</c>, <c>SX</c>,
        /// <c>SZ</c>, <c>TA</c>, <c>TC</c>, <c>TD</c>, <c>TF</c>, <c>TG</c>, <c>TH</c>, <c>TJ</c>,
        /// <c>TK</c>, <c>TL</c>, <c>TM</c>, <c>TN</c>, <c>TO</c>, <c>TR</c>, <c>TT</c>, <c>TV</c>,
        /// <c>TW</c>, <c>TZ</c>, <c>UA</c>, <c>UG</c>, <c>US</c>, <c>UY</c>, <c>UZ</c>, <c>VA</c>,
        /// <c>VC</c>, <c>VE</c>, <c>VG</c>, <c>VN</c>, <c>VU</c>, <c>WF</c>, <c>WS</c>, <c>XK</c>,
        /// <c>YE</c>, <c>YT</c>, <c>ZA</c>, <c>ZM</c>, <c>ZW</c>, or <c>ZZ</c>.
        /// </summary>
        [JsonProperty("allowed_countries")]
        public List<string> AllowedCountries { get; set; }
    }
}
