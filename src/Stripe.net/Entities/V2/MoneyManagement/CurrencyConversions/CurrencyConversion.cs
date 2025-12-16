// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The CurrencyConversion object. Contains details such as the amount debited and credited
    /// and the FinancialAccount the CurrencyConversion was performed on.
    /// </summary>
    public class CurrencyConversion : StripeEntity<CurrencyConversion>, IHasId, IHasObject
    {
        /// <summary>
        /// The id of the CurrencyConversion.
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
        /// The time the CurrencyConversion was created at.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The exchange rate used when processing the CurrencyConversion.
        /// </summary>
        [JsonProperty("exchange_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exchange_rate")]
#endif
        public string ExchangeRate { get; set; }

        /// <summary>
        /// The FinancialAccount the CurrencyConversion was performed on.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The from block containing what was debited.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public CurrencyConversionFrom From { get; set; }

        /// <summary>
        /// If the CurrencyConversion was performed in livemode or not.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The to block containing what was credited.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public CurrencyConversionTo To { get; set; }
    }
}
