// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationAuthorizationDetails : StripeEntity<IssuingAuthorizationEvaluationAuthorizationDetails>
    {
        /// <summary>
        /// The total amount of the authorization in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// How the card details were provided.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_method")]
#endif
        public string AuthorizationMethod { get; set; }

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
        /// Defines how the card's information was entered for the authorization.
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
        /// Raw code indicating the entry mode from the network message.
        /// </summary>
        [JsonProperty("entry_mode_raw_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entry_mode_raw_code")]
#endif
        public string EntryModeRawCode { get; set; }

        /// <summary>
        /// The timestamp of the authorization initiated in seconds.
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("initiated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime InitiatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Defines how the card was read at the point of sale.
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
        /// Raw code indicating the point of sale condition from the network message.
        /// </summary>
        [JsonProperty("point_of_sale_condition_raw_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("point_of_sale_condition_raw_code")]
#endif
        public string PointOfSaleConditionRawCode { get; set; }

        /// <summary>
        /// User's specified unique ID for this authorization attempt (e.g., RRN or internal
        /// reference).
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}
