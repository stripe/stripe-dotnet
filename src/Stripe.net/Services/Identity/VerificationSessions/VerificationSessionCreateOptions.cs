// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class VerificationSessionCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        [STJS.JsonPropertyName("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Confirm and submit the provided details for verification.
        /// </summary>
        [JsonProperty("confirm")]
        [STJS.JsonPropertyName("confirm")]
        public bool? Confirm { get; set; }

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
        /// A set of options for the session’s verification checks.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public VerificationSessionOptionsOptions Options { get; set; }

        /// <summary>
        /// Details provided about the user being verified. These details might be shown to the
        /// user.
        /// </summary>
        [JsonProperty("provided_details")]
        [STJS.JsonPropertyName("provided_details")]
        public VerificationSessionProvidedDetailsOptions ProvidedDetails { get; set; }

        /// <summary>
        /// Customer ID.
        /// </summary>
        [JsonProperty("related_customer")]
        [STJS.JsonPropertyName("related_customer")]
        public string RelatedCustomer { get; set; }

        /// <summary>
        /// The ID of the Account representing a customer.
        /// </summary>
        [JsonProperty("related_customer_account")]
        [STJS.JsonPropertyName("related_customer_account")]
        public string RelatedCustomerAccount { get; set; }

        /// <summary>
        /// Tokens referencing a Person resource and its associated account.
        /// </summary>
        [JsonProperty("related_person")]
        [STJS.JsonPropertyName("related_person")]
        public VerificationSessionRelatedPersonOptions RelatedPerson { get; set; }

        /// <summary>
        /// The URL that the user will be redirected to upon completing the verification flow.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The type of <a href="https://docs.stripe.com/identity/verification-checks">verification
        /// check</a> to be performed. You must provide a <c>type</c> if not passing
        /// <c>verification_flow</c>.
        /// One of: <c>document</c>, <c>email</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of a verification flow from the Dashboard. See
        /// https://docs.stripe.com/identity/verification-flows.
        /// </summary>
        [JsonProperty("verification_flow")]
        [STJS.JsonPropertyName("verification_flow")]
        public string VerificationFlow { get; set; }
    }
}
