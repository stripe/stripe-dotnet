// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The cardholder's billing address.
        /// </summary>
        [JsonProperty("billing")]
        public CardholderBillingOptions Billing { get; set; }

        /// <summary>
        /// Additional information about a <c>company</c> cardholder.
        /// </summary>
        [JsonProperty("company")]
        public CardholderCompanyOptions Company { get; set; }

        /// <summary>
        /// The cardholder's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Additional information about an <c>individual</c> cardholder.
        /// </summary>
        [JsonProperty("individual")]
        public CardholderIndividualOptions Individual { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder's name. This will be printed on cards issued to them. The maximum length
        /// of this field is 24 characters. This field cannot contain any special characters or
        /// numbers.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The cardholder's phone number. This will be transformed to <a
        /// href="https://en.wikipedia.org/wiki/E.164">E.164</a> if it is not provided in that
        /// format already. This is required for all cardholders who will be creating EU cards. See
        /// the <a href="https://stripe.com/docs/issuing/3d-secure#when-is-3d-secure-applied">3D
        /// Secure documentation</a> for more details.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Rules that control spending across this cardholder's cards. Refer to our <a
        /// href="https://stripe.com/docs/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
        public CardholderSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Specifies whether to permit authorizations on this cardholder's cards. Defaults to
        /// <c>active</c>.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// One of <c>individual</c> or <c>company</c>. See <a
        /// href="https://stripe.com/docs/issuing/other/choose-cardholder">Choose a cardholder
        /// type</a> for more details.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
