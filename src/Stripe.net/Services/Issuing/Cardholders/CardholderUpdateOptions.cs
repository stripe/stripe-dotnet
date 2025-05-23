// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardholderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The cardholder's billing address.
        /// </summary>
        [JsonProperty("billing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing")]
#endif
        public CardholderBillingOptions Billing { get; set; }

        /// <summary>
        /// Additional information about a <c>company</c> cardholder.
        /// </summary>
        [JsonProperty("company")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company")]
#endif
        public CardholderCompanyOptions Company { get; set; }

        /// <summary>
        /// The cardholder's email address.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// Additional information about an <c>individual</c> cardholder.
        /// </summary>
        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif
        public CardholderIndividualOptions Individual { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder's phone number. This is required for all cardholders who will be creating
        /// EU cards. See the <a href="https://stripe.com/docs/issuing/3d-secure">3D Secure
        /// documentation</a> for more details.
        /// </summary>
        [JsonProperty("phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number")]
#endif
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The cardholder’s preferred locales (languages), ordered by preference. Locales can be
        /// <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, or <c>it</c>. This changes the language of
        /// the <a href="https://stripe.com/docs/issuing/3d-secure">3D Secure flow</a> and one-time
        /// password messages sent to the cardholder.
        /// One of: <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, or <c>it</c>.
        /// </summary>
        [JsonProperty("preferred_locales")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_locales")]
#endif
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// Rules that control spending across this cardholder's cards. Refer to our <a
        /// href="https://stripe.com/docs/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spending_controls")]
#endif
        public CardholderSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Specifies whether to permit authorizations on this cardholder's cards.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
