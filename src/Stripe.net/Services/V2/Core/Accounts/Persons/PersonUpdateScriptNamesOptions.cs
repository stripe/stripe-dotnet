// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PersonUpdateScriptNamesOptions : INestedOptions
    {
        [JsonProperty("kana")]
        [JsonConverter(typeof(EmptyableConverter<PersonUpdateScriptNamesKanaOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<PersonUpdateScriptNamesKanaOptions>))]
#endif
        internal Emptyable<PersonUpdateScriptNamesKanaOptions> InternalKana { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKana
        {
            get => this.InternalKana?.Empty ?? false;
            set
            {
                this.InternalKana ??= new Emptyable<PersonUpdateScriptNamesKanaOptions>();
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
        public PersonUpdateScriptNamesKanaOptions Kana
        {
            get => this.InternalKana?.Value;
            set
            {
                this.InternalKana ??= new Emptyable<PersonUpdateScriptNamesKanaOptions>();
                this.InternalKana.Value = value;
            }
        }

        [JsonProperty("kanji")]
        [JsonConverter(typeof(EmptyableConverter<PersonUpdateScriptNamesKanjiOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<PersonUpdateScriptNamesKanjiOptions>))]
#endif
        internal Emptyable<PersonUpdateScriptNamesKanjiOptions> InternalKanji { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKanji
        {
            get => this.InternalKanji?.Empty ?? false;
            set
            {
                this.InternalKanji ??= new Emptyable<PersonUpdateScriptNamesKanjiOptions>();
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
        public PersonUpdateScriptNamesKanjiOptions Kanji
        {
            get => this.InternalKanji?.Value;
            set
            {
                this.InternalKanji ??= new Emptyable<PersonUpdateScriptNamesKanjiOptions>();
                this.InternalKanji.Value = value;
            }
        }
    }
}
