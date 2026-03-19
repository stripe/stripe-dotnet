// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuingAuthorizationEvaluationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details about the authorization.
        /// </summary>
        [JsonProperty("authorization_details")]
        [STJS.JsonPropertyName("authorization_details")]
        public IssuingAuthorizationEvaluationAuthorizationDetailsOptions AuthorizationDetails { get; set; }

        /// <summary>
        /// Details about the card used in the authorization.
        /// </summary>
        [JsonProperty("card_details")]
        [STJS.JsonPropertyName("card_details")]
        public IssuingAuthorizationEvaluationCardDetailsOptions CardDetails { get; set; }

        /// <summary>
        /// Details about the cardholder.
        /// </summary>
        [JsonProperty("cardholder_details")]
        [STJS.JsonPropertyName("cardholder_details")]
        public IssuingAuthorizationEvaluationCardholderDetailsOptions CardholderDetails { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_details")]
        [STJS.JsonPropertyName("merchant_details")]
        public IssuingAuthorizationEvaluationMerchantDetailsOptions MerchantDetails { get; set; }

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
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_details")]
        [STJS.JsonPropertyName("network_details")]
        public IssuingAuthorizationEvaluationNetworkDetailsOptions NetworkDetails { get; set; }

        /// <summary>
        /// Details about the token, if a tokenized payment method was used for the authorization.
        /// </summary>
        [JsonProperty("token_details")]
        [STJS.JsonPropertyName("token_details")]
        public IssuingAuthorizationEvaluationTokenDetailsOptions TokenDetails { get; set; }

        /// <summary>
        /// Details about verification data for the authorization.
        /// </summary>
        [JsonProperty("verification_details")]
        [STJS.JsonPropertyName("verification_details")]
        public IssuingAuthorizationEvaluationVerificationDetailsOptions VerificationDetails { get; set; }
    }
}
