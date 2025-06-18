// File generated from our OpenAPI spec
namespace Stripe.V2.Core
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
    public class AccountUpdateIdentityIndividualOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("additional_addresses")]
        [JsonConverter(typeof(EmptyableConverter<List<AccountUpdateIdentityIndividualAdditionalAddressOptions>>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_addresses")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<List<AccountUpdateIdentityIndividualAdditionalAddressOptions>>))]
#endif
        internal Emptyable<List<AccountUpdateIdentityIndividualAdditionalAddressOptions>> InternalAdditionalAddresses { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyAdditionalAddresses
        {
            get => this.InternalAdditionalAddresses?.Empty ?? false;
            set
            {
                this.InternalAdditionalAddresses ??= new Emptyable<List<AccountUpdateIdentityIndividualAdditionalAddressOptions>>();
                this.InternalAdditionalAddresses.Empty = value;
            }
        }

        /// <summary>
        /// Additional addresses associated with the individual.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<AccountUpdateIdentityIndividualAdditionalAddressOptions> AdditionalAddresses
        {
            get => this.InternalAdditionalAddresses?.Value;
            set
            {
                this.InternalAdditionalAddresses ??= new Emptyable<List<AccountUpdateIdentityIndividualAdditionalAddressOptions>>();
                this.InternalAdditionalAddresses.Value = value;
            }
        }

        [JsonProperty("additional_names")]
        [JsonConverter(typeof(EmptyableConverter<List<AccountUpdateIdentityIndividualAdditionalNameOptions>>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_names")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<List<AccountUpdateIdentityIndividualAdditionalNameOptions>>))]
#endif
        internal Emptyable<List<AccountUpdateIdentityIndividualAdditionalNameOptions>> InternalAdditionalNames { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyAdditionalNames
        {
            get => this.InternalAdditionalNames?.Empty ?? false;
            set
            {
                this.InternalAdditionalNames ??= new Emptyable<List<AccountUpdateIdentityIndividualAdditionalNameOptions>>();
                this.InternalAdditionalNames.Empty = value;
            }
        }

        /// <summary>
        /// Additional names (e.g. aliases) associated with the individual.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<AccountUpdateIdentityIndividualAdditionalNameOptions> AdditionalNames
        {
            get => this.InternalAdditionalNames?.Value;
            set
            {
                this.InternalAdditionalNames ??= new Emptyable<List<AccountUpdateIdentityIndividualAdditionalNameOptions>>();
                this.InternalAdditionalNames.Value = value;
            }
        }

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
        /// The individual's residential address.
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

        [JsonProperty("date_of_birth")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualDateOfBirthOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date_of_birth")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualDateOfBirthOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualDateOfBirthOptions> InternalDateOfBirth { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDateOfBirth
        {
            get => this.InternalDateOfBirth?.Empty ?? false;
            set
            {
                this.InternalDateOfBirth ??= new Emptyable<AccountUpdateIdentityIndividualDateOfBirthOptions>();
                this.InternalDateOfBirth.Empty = value;
            }
        }

        /// <summary>
        /// The individual's date of birth.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualDateOfBirthOptions DateOfBirth
        {
            get => this.InternalDateOfBirth?.Value;
            set
            {
                this.InternalDateOfBirth ??= new Emptyable<AccountUpdateIdentityIndividualDateOfBirthOptions>();
                this.InternalDateOfBirth.Value = value;
            }
        }

        [JsonProperty("documents")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualDocumentsOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("documents")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualDocumentsOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualDocumentsOptions> InternalDocuments { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyDocuments
        {
            get => this.InternalDocuments?.Empty ?? false;
            set
            {
                this.InternalDocuments ??= new Emptyable<AccountUpdateIdentityIndividualDocumentsOptions>();
                this.InternalDocuments.Empty = value;
            }
        }

        /// <summary>
        /// Documents that may be submitted to satisfy various informational requests.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualDocumentsOptions Documents
        {
            get => this.InternalDocuments?.Value;
            set
            {
                this.InternalDocuments ??= new Emptyable<AccountUpdateIdentityIndividualDocumentsOptions>();
                this.InternalDocuments.Value = value;
            }
        }

        [JsonProperty("email")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalEmail { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyEmail
        {
            get => this.InternalEmail?.Empty ?? false;
            set
            {
                this.InternalEmail ??= new Emptyable<string>();
                this.InternalEmail.Empty = value;
            }
        }

        /// <summary>
        /// The individual's email address.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Email
        {
            get => this.InternalEmail?.Value;
            set
            {
                this.InternalEmail ??= new Emptyable<string>();
                this.InternalEmail.Value = value;
            }
        }

        [JsonProperty("given_name")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("given_name")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalGivenName { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyGivenName
        {
            get => this.InternalGivenName?.Empty ?? false;
            set
            {
                this.InternalGivenName ??= new Emptyable<string>();
                this.InternalGivenName.Empty = value;
            }
        }

        /// <summary>
        /// The individual's first name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GivenName
        {
            get => this.InternalGivenName?.Value;
            set
            {
                this.InternalGivenName ??= new Emptyable<string>();
                this.InternalGivenName.Value = value;
            }
        }

        [JsonProperty("id_numbers")]
        [JsonConverter(typeof(EmptyableConverter<List<AccountUpdateIdentityIndividualIdNumberOptions>>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_numbers")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<List<AccountUpdateIdentityIndividualIdNumberOptions>>))]
#endif
        internal Emptyable<List<AccountUpdateIdentityIndividualIdNumberOptions>> InternalIdNumbers { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyIdNumbers
        {
            get => this.InternalIdNumbers?.Empty ?? false;
            set
            {
                this.InternalIdNumbers ??= new Emptyable<List<AccountUpdateIdentityIndividualIdNumberOptions>>();
                this.InternalIdNumbers.Empty = value;
            }
        }

        /// <summary>
        /// The identification numbers (e.g., SSN) associated with the individual.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public List<AccountUpdateIdentityIndividualIdNumberOptions> IdNumbers
        {
            get => this.InternalIdNumbers?.Value;
            set
            {
                this.InternalIdNumbers ??= new Emptyable<List<AccountUpdateIdentityIndividualIdNumberOptions>>();
                this.InternalIdNumbers.Value = value;
            }
        }

        [JsonProperty("legal_gender")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legal_gender")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalLegalGender { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyLegalGender
        {
            get => this.InternalLegalGender?.Empty ?? false;
            set
            {
                this.InternalLegalGender ??= new Emptyable<string>();
                this.InternalLegalGender.Empty = value;
            }
        }

        /// <summary>
        /// The individual's gender (International regulations require either "male" or "female").
        /// One of: <c>female</c>, or <c>male</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string LegalGender
        {
            get => this.InternalLegalGender?.Value;
            set
            {
                this.InternalLegalGender ??= new Emptyable<string>();
                this.InternalLegalGender.Value = value;
            }
        }

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
        /// The countries where the individual is a national. Two-letter country code (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
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

        [JsonProperty("phone")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalPhone { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyPhone
        {
            get => this.InternalPhone?.Empty ?? false;
            set
            {
                this.InternalPhone ??= new Emptyable<string>();
                this.InternalPhone.Empty = value;
            }
        }

        /// <summary>
        /// The individual's phone number.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Phone
        {
            get => this.InternalPhone?.Value;
            set
            {
                this.InternalPhone ??= new Emptyable<string>();
                this.InternalPhone.Value = value;
            }
        }

        [JsonProperty("political_exposure")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("political_exposure")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalPoliticalExposure { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyPoliticalExposure
        {
            get => this.InternalPoliticalExposure?.Empty ?? false;
            set
            {
                this.InternalPoliticalExposure ??= new Emptyable<string>();
                this.InternalPoliticalExposure.Empty = value;
            }
        }

        /// <summary>
        /// The individual's political exposure.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PoliticalExposure
        {
            get => this.InternalPoliticalExposure?.Value;
            set
            {
                this.InternalPoliticalExposure ??= new Emptyable<string>();
                this.InternalPoliticalExposure.Value = value;
            }
        }

        [JsonProperty("relationship")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualRelationshipOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("relationship")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualRelationshipOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualRelationshipOptions> InternalRelationship { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyRelationship
        {
            get => this.InternalRelationship?.Empty ?? false;
            set
            {
                this.InternalRelationship ??= new Emptyable<AccountUpdateIdentityIndividualRelationshipOptions>();
                this.InternalRelationship.Empty = value;
            }
        }

        /// <summary>
        /// The relationship that this individual has with the account's identity.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualRelationshipOptions Relationship
        {
            get => this.InternalRelationship?.Value;
            set
            {
                this.InternalRelationship ??= new Emptyable<AccountUpdateIdentityIndividualRelationshipOptions>();
                this.InternalRelationship.Value = value;
            }
        }

        [JsonProperty("script_addresses")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualScriptAddressesOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_addresses")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualScriptAddressesOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualScriptAddressesOptions> InternalScriptAddresses { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyScriptAddresses
        {
            get => this.InternalScriptAddresses?.Empty ?? false;
            set
            {
                this.InternalScriptAddresses ??= new Emptyable<AccountUpdateIdentityIndividualScriptAddressesOptions>();
                this.InternalScriptAddresses.Empty = value;
            }
        }

        /// <summary>
        /// The script addresses (e.g., non-Latin characters) associated with the individual.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualScriptAddressesOptions ScriptAddresses
        {
            get => this.InternalScriptAddresses?.Value;
            set
            {
                this.InternalScriptAddresses ??= new Emptyable<AccountUpdateIdentityIndividualScriptAddressesOptions>();
                this.InternalScriptAddresses.Value = value;
            }
        }

        [JsonProperty("script_names")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualScriptNamesOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_names")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualScriptNamesOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualScriptNamesOptions> InternalScriptNames { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyScriptNames
        {
            get => this.InternalScriptNames?.Empty ?? false;
            set
            {
                this.InternalScriptNames ??= new Emptyable<AccountUpdateIdentityIndividualScriptNamesOptions>();
                this.InternalScriptNames.Empty = value;
            }
        }

        /// <summary>
        /// The individuals primary name in non latin script.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualScriptNamesOptions ScriptNames
        {
            get => this.InternalScriptNames?.Value;
            set
            {
                this.InternalScriptNames ??= new Emptyable<AccountUpdateIdentityIndividualScriptNamesOptions>();
                this.InternalScriptNames.Value = value;
            }
        }

        [JsonProperty("surname")]
        [JsonConverter(typeof(EmptyableConverter<string>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("surname")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<string>))]
#endif
        internal Emptyable<string> InternalSurname { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptySurname
        {
            get => this.InternalSurname?.Empty ?? false;
            set
            {
                this.InternalSurname ??= new Emptyable<string>();
                this.InternalSurname.Empty = value;
            }
        }

        /// <summary>
        /// The individual's last name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string Surname
        {
            get => this.InternalSurname?.Value;
            set
            {
                this.InternalSurname ??= new Emptyable<string>();
                this.InternalSurname.Value = value;
            }
        }
    }
}
