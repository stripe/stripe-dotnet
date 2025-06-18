// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountIdentityIndividualScriptAddressesKanji : StripeEntity<AccountIdentityIndividualScriptAddressesKanji>
    {
        /// <summary>
        /// City, district, suburb, town, or village.
        /// </summary>
        [JsonProperty("city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("city")]
#endif
        public string City { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// One of: <c>ad</c>, <c>ae</c>, <c>af</c>, <c>ag</c>, <c>ai</c>, <c>al</c>, <c>am</c>,
        /// <c>ao</c>, <c>aq</c>, <c>ar</c>, <c>as</c>, <c>at</c>, <c>au</c>, <c>aw</c>, <c>ax</c>,
        /// <c>az</c>, <c>ba</c>, <c>bb</c>, <c>bd</c>, <c>be</c>, <c>bf</c>, <c>bg</c>, <c>bh</c>,
        /// <c>bi</c>, <c>bj</c>, <c>bl</c>, <c>bm</c>, <c>bn</c>, <c>bo</c>, <c>bq</c>, <c>br</c>,
        /// <c>bs</c>, <c>bt</c>, <c>bv</c>, <c>bw</c>, <c>by</c>, <c>bz</c>, <c>ca</c>, <c>cc</c>,
        /// <c>cd</c>, <c>cf</c>, <c>cg</c>, <c>ch</c>, <c>ci</c>, <c>ck</c>, <c>cl</c>, <c>cm</c>,
        /// <c>cn</c>, <c>co</c>, <c>cr</c>, <c>cu</c>, <c>cv</c>, <c>cw</c>, <c>cx</c>, <c>cy</c>,
        /// <c>cz</c>, <c>de</c>, <c>dj</c>, <c>dk</c>, <c>dm</c>, <c>do</c>, <c>dz</c>, <c>ec</c>,
        /// <c>ee</c>, <c>eg</c>, <c>eh</c>, <c>er</c>, <c>es</c>, <c>et</c>, <c>fi</c>, <c>fj</c>,
        /// <c>fk</c>, <c>fm</c>, <c>fo</c>, <c>fr</c>, <c>ga</c>, <c>gb</c>, <c>gd</c>, <c>ge</c>,
        /// <c>gf</c>, <c>gg</c>, <c>gh</c>, <c>gi</c>, <c>gl</c>, <c>gm</c>, <c>gn</c>, <c>gp</c>,
        /// <c>gq</c>, <c>gr</c>, <c>gs</c>, <c>gt</c>, <c>gu</c>, <c>gw</c>, <c>gy</c>, <c>hk</c>,
        /// <c>hm</c>, <c>hn</c>, <c>hr</c>, <c>ht</c>, <c>hu</c>, <c>id</c>, <c>ie</c>, <c>il</c>,
        /// <c>im</c>, <c>in</c>, <c>io</c>, <c>iq</c>, <c>ir</c>, <c>is</c>, <c>it</c>, <c>je</c>,
        /// <c>jm</c>, <c>jo</c>, <c>jp</c>, <c>ke</c>, <c>kg</c>, <c>kh</c>, <c>ki</c>, <c>km</c>,
        /// <c>kn</c>, <c>kp</c>, <c>kr</c>, <c>kw</c>, <c>ky</c>, <c>kz</c>, <c>la</c>, <c>lb</c>,
        /// <c>lc</c>, <c>li</c>, <c>lk</c>, <c>lr</c>, <c>ls</c>, <c>lt</c>, <c>lu</c>, <c>lv</c>,
        /// <c>ly</c>, <c>ma</c>, <c>mc</c>, <c>md</c>, <c>me</c>, <c>mf</c>, <c>mg</c>, <c>mh</c>,
        /// <c>mk</c>, <c>ml</c>, <c>mm</c>, <c>mn</c>, <c>mo</c>, <c>mp</c>, <c>mq</c>, <c>mr</c>,
        /// <c>ms</c>, <c>mt</c>, <c>mu</c>, <c>mv</c>, <c>mw</c>, <c>mx</c>, <c>my</c>, <c>mz</c>,
        /// <c>na</c>, <c>nc</c>, <c>ne</c>, <c>nf</c>, <c>ng</c>, <c>ni</c>, <c>nl</c>, <c>no</c>,
        /// <c>np</c>, <c>nr</c>, <c>nu</c>, <c>nz</c>, <c>om</c>, <c>pa</c>, <c>pe</c>, <c>pf</c>,
        /// <c>pg</c>, <c>ph</c>, <c>pk</c>, <c>pl</c>, <c>pm</c>, <c>pn</c>, <c>pr</c>, <c>ps</c>,
        /// <c>pt</c>, <c>pw</c>, <c>py</c>, <c>qa</c>, <c>qz</c>, <c>re</c>, <c>ro</c>, <c>rs</c>,
        /// <c>ru</c>, <c>rw</c>, <c>sa</c>, <c>sb</c>, <c>sc</c>, <c>sd</c>, <c>se</c>, <c>sg</c>,
        /// <c>sh</c>, <c>si</c>, <c>sj</c>, <c>sk</c>, <c>sl</c>, <c>sm</c>, <c>sn</c>, <c>so</c>,
        /// <c>sr</c>, <c>ss</c>, <c>st</c>, <c>sv</c>, <c>sx</c>, <c>sy</c>, <c>sz</c>, <c>tc</c>,
        /// <c>td</c>, <c>tf</c>, <c>tg</c>, <c>th</c>, <c>tj</c>, <c>tk</c>, <c>tl</c>, <c>tm</c>,
        /// <c>tn</c>, <c>to</c>, <c>tr</c>, <c>tt</c>, <c>tv</c>, <c>tw</c>, <c>tz</c>, <c>ua</c>,
        /// <c>ug</c>, <c>um</c>, <c>us</c>, <c>uy</c>, <c>uz</c>, <c>va</c>, <c>vc</c>, <c>ve</c>,
        /// <c>vg</c>, <c>vi</c>, <c>vn</c>, <c>vu</c>, <c>wf</c>, <c>ws</c>, <c>xx</c>, <c>ye</c>,
        /// <c>yt</c>, <c>za</c>, <c>zm</c>, or <c>zw</c>.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Address line 1 (e.g., street, PO Box, or company name).
        /// </summary>
        [JsonProperty("line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line1")]
#endif
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2 (e.g., apartment, suite, unit, or building).
        /// </summary>
        [JsonProperty("line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line2")]
#endif
        public string Line2 { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif
        public string PostalCode { get; set; }

        /// <summary>
        /// State, county, province, or region.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// Town or cho-me.
        /// </summary>
        [JsonProperty("town")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("town")]
#endif
        public string Town { get; set; }
    }
}
