// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermPricingOverrideOverwrite : StripeEntity<ContractTermPricingOverrideOverwrite>
    {
        /// <summary>
        /// Whether the replacement pricing is per unit or tiered.
        /// One of: <c>per_unit</c>, or <c>tiered</c>.
        /// </summary>
        [JsonProperty("billing_scheme")]
        [STJS.JsonPropertyName("billing_scheme")]
        public string BillingScheme { get; set; }

        /// <summary>
        /// Replacement pricing tiers.
        /// </summary>
        [JsonProperty("tiers")]
        [STJS.JsonPropertyName("tiers")]
        public List<ContractTermPricingOverrideOverwriteTier> Tiers { get; set; }

        /// <summary>
        /// How the pricing tiers are applied.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiers_mode")]
        [STJS.JsonPropertyName("tiers_mode")]
        public string TiersMode { get; set; }

        /// <summary>
        /// The replacement per-unit amount in minor currency units.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
