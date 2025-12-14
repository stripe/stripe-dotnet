// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardListOptions : ListOptions
    {
        /// <summary>
        /// Only return cards belonging to the Cardholder with the provided ID.
        /// </summary>
        [JsonProperty("cardholder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder")]
#endif
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return cards that were issued during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return cards that have the given expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Only return cards that have the given expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public long? ExpYear { get; set; }

        /// <summary>
        /// Only return cards that have the given last four digits.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        [JsonProperty("personalization_design")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("personalization_design")]
#endif
        public string PersonalizationDesign { get; set; }

        /// <summary>
        /// Only return cards that have the given status. One of <c>active</c>, <c>inactive</c>, or
        /// <c>canceled</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Only return cards that have the given type. One of <c>virtual</c> or <c>physical</c>.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Filter cards by wallet settings.
        /// </summary>
        [JsonProperty("wallets")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallets")]
#endif
        public CardWalletsOptions Wallets { get; set; }
    }
}
