// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Currency Conversion represents a standalone conversion between currencies in a <a
    /// href="https://docs.stripe.com/api/v2/money-management/financial-accounts">Financial
    /// Account</a> or the payments balance.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CurrencyConversion : StripeEntity<CurrencyConversion>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the Currency Conversion.
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
        /// The time the Currency Conversion was created at.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The exchange rate used, excluding applicable fees.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// The ID of the Financial Account the Currency Conversion was created in. If <c>null</c>,
        /// it was created in the payments balance.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The amount that was debited from the source currency.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public CurrencyConversionFrom From { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The amount that was credited to the destination currency.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public CurrencyConversionTo To { get; set; }
    }
}
