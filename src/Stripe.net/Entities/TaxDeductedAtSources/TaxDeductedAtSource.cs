// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxDeductedAtSource : StripeEntity<TaxDeductedAtSource>, IHasId, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The end of the invoicing period. This TDS applies to Stripe fees collected during this
        /// invoicing period.
        /// </summary>
        [JsonProperty("period_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("period_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PeriodEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The start of the invoicing period. This TDS applies to Stripe fees collected during this
        /// invoicing period.
        /// </summary>
        [JsonProperty("period_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("period_start")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PeriodStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The TAN that was supplied to Stripe when TDS was assessed.
        /// </summary>
        [JsonProperty("tax_deduction_account_number")]
        [STJS.JsonPropertyName("tax_deduction_account_number")]
        public string TaxDeductionAccountNumber { get; set; }
    }
}
