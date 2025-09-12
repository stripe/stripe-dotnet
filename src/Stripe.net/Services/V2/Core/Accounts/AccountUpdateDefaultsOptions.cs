// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateDefaultsOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The Account's preferred locales (languages), ordered by preference.
        /// One of: <c>ar-SA</c>, <c>bg</c>, <c>bg-BG</c>, <c>cs</c>, <c>cs-CZ</c>, <c>da</c>,
        /// <c>da-DK</c>, <c>de</c>, <c>de-DE</c>, <c>el</c>, <c>el-GR</c>, <c>en</c>, <c>en-AU</c>,
        /// <c>en-CA</c>, <c>en-GB</c>, <c>en-IE</c>, <c>en-IN</c>, <c>en-NZ</c>, <c>en-SG</c>,
        /// <c>en-US</c>, <c>es</c>, <c>es-419</c>, <c>es-ES</c>, <c>et</c>, <c>et-EE</c>,
        /// <c>fi</c>, <c>fil</c>, <c>fil-PH</c>, <c>fi-FI</c>, <c>fr</c>, <c>fr-CA</c>,
        /// <c>fr-FR</c>, <c>he-IL</c>, <c>hr</c>, <c>hr-HR</c>, <c>hu</c>, <c>hu-HU</c>, <c>id</c>,
        /// <c>id-ID</c>, <c>it</c>, <c>it-IT</c>, <c>ja</c>, <c>ja-JP</c>, <c>ko</c>, <c>ko-KR</c>,
        /// <c>lt</c>, <c>lt-LT</c>, <c>lv</c>, <c>lv-LV</c>, <c>ms</c>, <c>ms-MY</c>, <c>mt</c>,
        /// <c>mt-MT</c>, <c>nb</c>, <c>nb-NO</c>, <c>nl</c>, <c>nl-NL</c>, <c>pl</c>, <c>pl-PL</c>,
        /// <c>pt</c>, <c>pt-BR</c>, <c>pt-PT</c>, <c>ro</c>, <c>ro-RO</c>, <c>ru</c>, <c>ru-RU</c>,
        /// <c>sk</c>, <c>sk-SK</c>, <c>sl</c>, <c>sl-SI</c>, <c>sv</c>, <c>sv-SE</c>, <c>th</c>,
        /// <c>th-TH</c>, <c>tr</c>, <c>tr-TR</c>, <c>vi</c>, <c>vi-VN</c>, <c>zh</c>,
        /// <c>zh-Hans</c>, <c>zh-Hant-HK</c>, <c>zh-Hant-TW</c>, <c>zh-HK</c>, or <c>zh-TW</c>.
        /// </summary>
        [JsonProperty("locales")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("locales")]
#endif
        public List<string> Locales { get; set; }

        /// <summary>
        /// Default responsibilities held by either Stripe or the platform.
        /// </summary>
        [JsonProperty("responsibilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("responsibilities")]
#endif
        public AccountUpdateDefaultsResponsibilitiesOptions Responsibilities { get; set; }
    }
}
