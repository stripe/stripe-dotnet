// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardholderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The cardholder's billing address.
        /// </summary>
        [JsonProperty("billing")]
        [STJS.JsonPropertyName("billing")]
        public CardholderBillingOptions Billing { get; set; }

        /// <summary>
        /// Additional information about a <c>company</c> cardholder.
        /// </summary>
        [JsonProperty("company")]
        [STJS.JsonPropertyName("company")]
        public CardholderCompanyOptions Company { get; set; }

        /// <summary>
        /// The cardholder's email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Additional information about an <c>individual</c> cardholder.
        /// </summary>
        [JsonProperty("individual")]
        [STJS.JsonPropertyName("individual")]
        public CardholderIndividualOptions Individual { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder's phone number. This is required for all cardholders who will be creating
        /// EU cards. See the <a href="https://docs.stripe.com/issuing/3d-secure">3D Secure
        /// documentation</a> for more details.
        /// </summary>
        [JsonProperty("phone_number")]
        [STJS.JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The cardholder’s preferred locales (languages), ordered by preference. Locales can be
        /// <c>da</c>, <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, <c>it</c>, <c>pl</c>, or
        /// <c>sv</c>. This changes the language of the <a
        /// href="https://docs.stripe.com/issuing/3d-secure">3D Secure flow</a> and one-time
        /// password messages sent to the cardholder.
        /// One of: <c>de</c>, <c>en</c>, <c>es</c>, <c>fr</c>, or <c>it</c>.
        /// </summary>
        [JsonProperty("preferred_locales")]
        [STJS.JsonPropertyName("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// Rules that control spending across this cardholder's cards. Refer to our <a
        /// href="https://docs.stripe.com/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
        [STJS.JsonPropertyName("spending_controls")]
        public CardholderSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Specifies whether to permit authorizations on this cardholder's cards.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
