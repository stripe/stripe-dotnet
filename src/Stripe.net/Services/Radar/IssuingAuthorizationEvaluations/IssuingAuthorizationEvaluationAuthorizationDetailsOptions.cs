// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationAuthorizationDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The authorization amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The method used for authorization.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_method")]
#endif
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// Three-letter ISO currency code in lowercase.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The card entry mode.
        /// One of: <c>contactless</c>, <c>contactless_magstripe</c>, <c>credential_on_file</c>,
        /// <c>integrated_circuit_card</c>, <c>magstripe</c>, <c>magstripe_no_cvv</c>,
        /// <c>manual</c>, <c>other</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("entry_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entry_mode")]
#endif
        public string EntryMode { get; set; }

        /// <summary>
        /// The raw code for the card entry mode.
        /// </summary>
        [JsonProperty("entry_mode_raw_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entry_mode_raw_code")]
#endif
        public string EntryModeRawCode { get; set; }

        /// <summary>
        /// The time when the authorization was initiated (Unix timestamp).
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("initiated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? InitiatedAt { get; set; }

        /// <summary>
        /// The point of sale condition.
        /// One of: <c>account_verification</c>, <c>card_not_present</c>, <c>card_present</c>,
        /// <c>e_commerce</c>, <c>key_entered_pos</c>, <c>missing</c>, <c>moto</c>, <c>other</c>,
        /// <c>pin_entered</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("point_of_sale_condition")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("point_of_sale_condition")]
#endif
        public string PointOfSaleCondition { get; set; }

        /// <summary>
        /// The raw code for the point of sale condition.
        /// </summary>
        [JsonProperty("point_of_sale_condition_raw_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("point_of_sale_condition_raw_code")]
#endif
        public string PointOfSaleConditionRawCode { get; set; }

        /// <summary>
        /// External reference for the authorization.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
