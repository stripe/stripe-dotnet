// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardListOptions : ListOptions
    {
        /// <summary>
        /// Only return cards belonging to the Cardholder with the provided ID.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return cards that were issued during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return cards that have the given expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Only return cards that have the given expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Only return cards that have the given last four digits.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonProperty("personalization_design")]
        [STJS.JsonPropertyName("personalization_design")]
        public string PersonalizationDesign { get; set; }

        /// <summary>
        /// Only return cards that have the given status. One of <c>active</c>, <c>inactive</c>, or
        /// <c>canceled</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return cards that have the given type. One of <c>virtual</c> or <c>physical</c>.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Filter cards by wallet settings.
        /// </summary>
        [JsonProperty("wallets")]
        [STJS.JsonPropertyName("wallets")]
        public CardWalletsOptions Wallets { get; set; }
    }
}
