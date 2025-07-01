// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class PersonUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Additional addresses associated with the person.
        /// </summary>
        [JsonProperty("additional_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_addresses")]
#endif
        public List<PersonUpdateAdditionalAddressOptions> AdditionalAddresses { get; set; }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the person.
        /// </summary>
        [JsonProperty("additional_names")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_names")]
#endif
        public List<PersonUpdateAdditionalNameOptions> AdditionalNames { get; set; }

        /// <summary>
        /// Attestations of accepted terms of service agreements.
        /// </summary>
        [JsonProperty("additional_terms_of_service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_terms_of_service")]
#endif
        public PersonUpdateAdditionalTermsOfServiceOptions AdditionalTermsOfService { get; set; }

        /// <summary>
        /// The primary address associated with the person.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public AddressJapanOptions Address { get; set; }

        /// <summary>
        /// The person's date of birth.
        /// </summary>
        [JsonProperty("date_of_birth")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date_of_birth")]
#endif
        public PersonUpdateDateOfBirthOptions DateOfBirth { get; set; }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonProperty("documents")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
#endif
        public PersonUpdateDocumentsOptions Documents { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        [JsonProperty("given_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
#endif
        public string GivenName { get; set; }

        /// <summary>
        /// The identification numbers (e.g., SSN) associated with the person.
        /// </summary>
        [JsonProperty("id_numbers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
#endif
        public List<PersonUpdateIdNumberOptions> IdNumbers { get; set; }

        /// <summary>
        /// The person's gender (International regulations require either "male" or "female").
        /// One of: <c>female</c>, or <c>male</c>.
        /// </summary>
        [JsonProperty("legal_gender")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_gender")]
#endif
        public string LegalGender { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The nationalities (countries) this person is associated with.
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
        [JsonProperty("nationalities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nationalities")]
#endif
        public List<string> Nationalities { get; set; }

        /// <summary>
        /// The phone number for this person.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// The person's political exposure.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("political_exposure")]
#endif
        public string PoliticalExposure { get; set; }

        /// <summary>
        /// The relationship that this person has with the Account's business or legal entity.
        /// </summary>
        [JsonProperty("relationship")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
#endif
        public PersonUpdateRelationshipOptions Relationship { get; set; }

        [JsonProperty("script_addresses")]
        [JsonConverter(typeof(EmptyableConverter<PersonUpdateScriptAddressesOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<PersonUpdateScriptAddressesOptions>))]
#endif
        internal Emptyable<PersonUpdateScriptAddressesOptions> InternalScriptAddresses { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyScriptAddresses
        {
            get => this.InternalScriptAddresses?.Empty ?? false;
            set
            {
                this.InternalScriptAddresses ??= new Emptyable<PersonUpdateScriptAddressesOptions>();
                this.InternalScriptAddresses.Empty = value;
            }
        }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the person.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PersonUpdateScriptAddressesOptions ScriptAddresses
        {
            get => this.InternalScriptAddresses?.Value;
            set
            {
                this.InternalScriptAddresses ??= new Emptyable<PersonUpdateScriptAddressesOptions>();
                this.InternalScriptAddresses.Value = value;
            }
        }

        [JsonProperty("script_names")]
        [JsonConverter(typeof(EmptyableConverter<PersonUpdateScriptNamesOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<PersonUpdateScriptNamesOptions>))]
#endif
        internal Emptyable<PersonUpdateScriptNamesOptions> InternalScriptNames { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyScriptNames
        {
            get => this.InternalScriptNames?.Empty ?? false;
            set
            {
                this.InternalScriptNames ??= new Emptyable<PersonUpdateScriptNamesOptions>();
                this.InternalScriptNames.Empty = value;
            }
        }

        /// <summary>
        /// The script names (e.g. non-Latin characters) associated with the person.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PersonUpdateScriptNamesOptions ScriptNames
        {
            get => this.InternalScriptNames?.Value;
            set
            {
                this.InternalScriptNames ??= new Emptyable<PersonUpdateScriptNamesOptions>();
                this.InternalScriptNames.Value = value;
            }
        }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [JsonProperty("surname")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
#endif
        public string Surname { get; set; }
    }
}
