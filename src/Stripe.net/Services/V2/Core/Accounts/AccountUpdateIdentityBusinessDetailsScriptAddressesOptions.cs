// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityBusinessDetailsScriptAddressesOptions : INestedOptions
    {
        [JsonProperty("kana")]
        [JsonConverter(typeof(EmptyableConverter<AddressJapanOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kana")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AddressJapanOptions>))]
#endif
        internal Emptyable<AddressJapanOptions> InternalKana { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKana
        {
            get => this.InternalKana?.Empty ?? false;
            set
            {
                this.InternalKana ??= new Emptyable<AddressJapanOptions>();
                this.InternalKana.Empty = value;
            }
        }

        /// <summary>
        /// Kana Address.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AddressJapanOptions Kana
        {
            get => this.InternalKana?.Value;
            set
            {
                this.InternalKana ??= new Emptyable<AddressJapanOptions>();
                this.InternalKana.Value = value;
            }
        }

        [JsonProperty("kanji")]
        [JsonConverter(typeof(EmptyableConverter<AddressJapanOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kanji")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<AddressJapanOptions>))]
#endif
        internal Emptyable<AddressJapanOptions> InternalKanji { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyKanji
        {
            get => this.InternalKanji?.Empty ?? false;
            set
            {
                this.InternalKanji ??= new Emptyable<AddressJapanOptions>();
                this.InternalKanji.Empty = value;
            }
        }

        /// <summary>
        /// Kanji Address.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public AddressJapanOptions Kanji
        {
            get => this.InternalKanji?.Value;
            set
            {
                this.InternalKanji ??= new Emptyable<AddressJapanOptions>();
                this.InternalKanji.Value = value;
            }
        }
    }
}
