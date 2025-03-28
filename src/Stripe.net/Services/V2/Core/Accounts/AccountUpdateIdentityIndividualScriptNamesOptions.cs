// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class AccountUpdateIdentityIndividualScriptNamesOptions : INestedOptions
    {
        [JsonProperty("kana")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualScriptNamesKanaOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualScriptNamesKanaOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualScriptNamesKanaOptions> InternalKana { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKana
        {
            get => this.InternalKana?.Empty ?? false;
            set
            {
                this.InternalKana ??= new Emptyable<AccountUpdateIdentityIndividualScriptNamesKanaOptions>();
                this.InternalKana.Empty = value;
            }
        }

        /// <summary>
        /// Persons name in kana script.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualScriptNamesKanaOptions Kana
        {
            get => this.InternalKana?.Value;
            set
            {
                this.InternalKana ??= new Emptyable<AccountUpdateIdentityIndividualScriptNamesKanaOptions>();
                this.InternalKana.Value = value;
            }
        }

        [JsonProperty("kanji")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityIndividualScriptNamesKanjiOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityIndividualScriptNamesKanjiOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityIndividualScriptNamesKanjiOptions> InternalKanji { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKanji
        {
            get => this.InternalKanji?.Empty ?? false;
            set
            {
                this.InternalKanji ??= new Emptyable<AccountUpdateIdentityIndividualScriptNamesKanjiOptions>();
                this.InternalKanji.Empty = value;
            }
        }

        /// <summary>
        /// Persons name in kanji script.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityIndividualScriptNamesKanjiOptions Kanji
        {
            get => this.InternalKanji?.Value;
            set
            {
                this.InternalKanji ??= new Emptyable<AccountUpdateIdentityIndividualScriptNamesKanjiOptions>();
                this.InternalKanji.Value = value;
            }
        }
    }
}
