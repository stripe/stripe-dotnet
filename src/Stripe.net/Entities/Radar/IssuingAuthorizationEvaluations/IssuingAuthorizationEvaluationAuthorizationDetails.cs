// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluationAuthorizationDetails : StripeEntity<IssuingAuthorizationEvaluationAuthorizationDetails>
    {
        /// <summary>
        /// The total amount of the authorization in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// How the card details were provided.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
        [STJS.JsonPropertyName("authorization_method")]
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Defines how the card's information was entered for the authorization.
        /// One of: <c>contactless</c>, <c>contactless_magstripe</c>, <c>credential_on_file</c>,
        /// <c>integrated_circuit_card</c>, <c>magstripe</c>, <c>magstripe_no_cvv</c>,
        /// <c>manual</c>, <c>other</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("entry_mode")]
        [STJS.JsonPropertyName("entry_mode")]
        public string EntryMode { get; set; }

        /// <summary>
        /// Raw code indicating the entry mode from the network message.
        /// </summary>
        [JsonProperty("entry_mode_raw_code")]
        [STJS.JsonPropertyName("entry_mode_raw_code")]
        public string EntryModeRawCode { get; set; }

        /// <summary>
        /// The timestamp of the authorization initiated in seconds.
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("initiated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime InitiatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Defines how the card was read at the point of sale.
        /// One of: <c>account_verification</c>, <c>card_not_present</c>, <c>card_present</c>,
        /// <c>e_commerce</c>, <c>key_entered_pos</c>, <c>missing</c>, <c>moto</c>, <c>other</c>,
        /// <c>pin_entered</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("point_of_sale_condition")]
        [STJS.JsonPropertyName("point_of_sale_condition")]
        public string PointOfSaleCondition { get; set; }

        /// <summary>
        /// Raw code indicating the point of sale condition from the network message.
        /// </summary>
        [JsonProperty("point_of_sale_condition_raw_code")]
        [STJS.JsonPropertyName("point_of_sale_condition_raw_code")]
        public string PointOfSaleConditionRawCode { get; set; }

        /// <summary>
        /// User's specified unique ID for this authorization attempt (e.g., RRN or internal
        /// reference).
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
