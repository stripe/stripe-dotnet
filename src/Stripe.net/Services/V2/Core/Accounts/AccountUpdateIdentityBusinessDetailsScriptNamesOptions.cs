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
    public class AccountUpdateIdentityBusinessDetailsScriptNamesOptions : INestedOptions
    {
        [JsonProperty("kana")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions> InternalKana { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKana
        {
            get => this.InternalKana?.Empty ?? false;
            set
            {
                this.InternalKana ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions>();
                this.InternalKana.Empty = value;
            }
        }

        /// <summary>
        /// Kana name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions Kana
        {
            get => this.InternalKana?.Value;
            set
            {
                this.InternalKana ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesKanaOptions>();
                this.InternalKana.Value = value;
            }
        }

        [JsonProperty("kanji")]
        [JsonConverter(typeof(EmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions>))]
#endif
        internal Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions> InternalKanji { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKanji
        {
            get => this.InternalKanji?.Empty ?? false;
            set
            {
                this.InternalKanji ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions>();
                this.InternalKanji.Empty = value;
            }
        }

        /// <summary>
        /// Kanji name.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions Kanji
        {
            get => this.InternalKanji?.Value;
            set
            {
                this.InternalKanji ??= new Emptyable<AccountUpdateIdentityBusinessDetailsScriptNamesKanjiOptions>();
                this.InternalKanji.Value = value;
            }
        }
    }
}
