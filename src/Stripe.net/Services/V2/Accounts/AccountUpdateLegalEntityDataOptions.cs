// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountUpdateLegalEntityDataOptions : INestedOptions
    {
        [JsonProperty("address")]
        [JsonConverter(typeof(EmptyableConverter<AddressJapanOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AddressJapanOptions>))]
#endif
        internal Emptyable<AddressJapanOptions> InternalAddress { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyAddress
        {
            get => this.InternalAddress?.Empty ?? false;
            set
            {
                this.InternalAddress ??= new Emptyable<AddressJapanOptions>();
                this.InternalAddress.Empty = value;
            }
        }

        /// <summary>
        /// The address of the Legal Entity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AddressJapanOptions Address
        {
            get => this.InternalAddress?.Value;
            set
            {
                this.InternalAddress ??= new Emptyable<AddressJapanOptions>();
                this.InternalAddress.Value = value;
            }
        }

        [JsonProperty("business_type")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_type")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalBusinessType { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyBusinessType
        {
            get => this.InternalBusinessType?.Empty ?? false;
            set
            {
                this.InternalBusinessType ??= new Emptyable<string>();
                this.InternalBusinessType.Empty = value;
            }
        }

        /// <summary>
        /// Closed Enum. The business type of the Legal Entity.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BusinessType
        {
            get => this.InternalBusinessType?.Value;
            set
            {
                this.InternalBusinessType ??= new Emptyable<string>();
                this.InternalBusinessType.Value = value;
            }
        }

        [JsonProperty("country")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalCountry { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyCountry
        {
            get => this.InternalCountry?.Empty ?? false;
            set
            {
                this.InternalCountry ??= new Emptyable<string>();
                this.InternalCountry.Empty = value;
            }
        }

        /// <summary>
        /// Open Enum. Two-letter country code (ISO 3166-1 alpha-2) for where the company or
        /// individual is located.
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
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Country
        {
            get => this.InternalCountry?.Value;
            set
            {
                this.InternalCountry ??= new Emptyable<string>();
                this.InternalCountry.Value = value;
            }
        }

        [JsonProperty("name")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalName { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyName
        {
            get => this.InternalName?.Empty ?? false;
            set
            {
                this.InternalName ??= new Emptyable<string>();
                this.InternalName.Empty = value;
            }
        }

        /// <summary>
        /// The legal name of this Legal Entity. Required unless the business type is
        /// <c>individual</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Name
        {
            get => this.InternalName?.Value;
            set
            {
                this.InternalName ??= new Emptyable<string>();
                this.InternalName.Value = value;
            }
        }

        [JsonProperty("representative")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateLegalEntityDataRepresentativeOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("representative")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateLegalEntityDataRepresentativeOptions>))]
#endif
        internal Emptyable<AccountUpdateLegalEntityDataRepresentativeOptions> InternalRepresentative { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyRepresentative
        {
            get => this.InternalRepresentative?.Empty ?? false;
            set
            {
                this.InternalRepresentative ??= new Emptyable<AccountUpdateLegalEntityDataRepresentativeOptions>();
                this.InternalRepresentative.Empty = value;
            }
        }

        /// <summary>
        /// The representative of the Legal Entity. This is the person nominated by the Legal Entity
        /// to provide information about themselves, and general information about the account. For
        /// legal entities with <c>individual</c> business type, this field is required and should
        /// contain the individual's information.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateLegalEntityDataRepresentativeOptions Representative
        {
            get => this.InternalRepresentative?.Value;
            set
            {
                this.InternalRepresentative ??= new Emptyable<AccountUpdateLegalEntityDataRepresentativeOptions>();
                this.InternalRepresentative.Value = value;
            }
        }
    }
}
