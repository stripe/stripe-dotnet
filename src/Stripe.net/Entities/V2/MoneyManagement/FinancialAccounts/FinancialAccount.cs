// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The Financial Account is the container that allows for the configuration of money
    /// movement.
    /// </summary>
    public class FinancialAccount : StripeEntity<FinancialAccount>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Multi-currency balance of this FinancialAccount, split by availability state. Each
        /// balance is represented as a hash where the key is the three-letter ISO currency code, in
        /// lowercase, and the value is the amount for that currency.
        /// </summary>
        [JsonProperty("balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance")]
#endif
        public FinancialAccountBalance Balance { get; set; }

        /// <summary>
        /// Open Enum. Two-letter country code that represents the country where the LegalEntity
        /// associated with the FinancialAccount is based in.
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
        /// <c>vg</c>, <c>vi</c>, <c>vn</c>, <c>vu</c>, <c>wf</c>, <c>ws</c>, <c>ye</c>, <c>yt</c>,
        /// <c>za</c>, <c>zm</c>, or <c>zw</c>.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// If this is a <c>other</c> FinancialAccount, this hash indicates what the actual type is.
        /// Upgrade your API version to see it reflected in <c>type</c>.
        /// </summary>
        [JsonProperty("other")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("other")]
#endif
        public FinancialAccountOther Other { get; set; }

        /// <summary>
        /// An enum value that specifies which state the FinancialAccount is in.
        /// One of: <c>closed</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// If this is a <c>storage</c> FinancialAccount, this hash includes details specific to
        /// <c>storage</c> FinancialAccounts.
        /// </summary>
        [JsonProperty("storage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("storage")]
#endif
        public FinancialAccountStorage Storage { get; set; }

        /// <summary>
        /// Type of the FinancialAccount. An additional hash is included on the FinancialAccount
        /// with a name matching this value. It contains additional information specific to the
        /// FinancialAccount type.
        /// One of: <c>other</c>, or <c>storage</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
