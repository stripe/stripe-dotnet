// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// The CurrencyConversion object. Contains details such as the amount debited and credited
    /// and the FinancialAccount the CurrencyConversion was performed on.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CurrencyConversion : StripeEntity<CurrencyConversion>, IHasId, IHasObject
    {
        /// <summary>
        /// The id of the CurrencyConversion.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The time the CurrencyConversion was created at.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The exchange rate used when processing the CurrencyConversion.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// The FinancialAccount the CurrencyConversion was performed on.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The from block containing what was debited.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public CurrencyConversionFrom From { get; set; }

        /// <summary>
        /// If the CurrencyConversion was performed in livemode or not.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The to block containing what was credited.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public CurrencyConversionTo To { get; set; }
    }
}
