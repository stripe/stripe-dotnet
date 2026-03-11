// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IssuingAuthorizationEvaluationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details about the authorization.
        /// </summary>
        [JsonProperty("authorization_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_details")]
#endif
        public IssuingAuthorizationEvaluationAuthorizationDetailsOptions AuthorizationDetails { get; set; }

        /// <summary>
        /// Details about the card used in the authorization.
        /// </summary>
        [JsonProperty("card_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_details")]
#endif
        public IssuingAuthorizationEvaluationCardDetailsOptions CardDetails { get; set; }

        /// <summary>
        /// Details about the cardholder.
        /// </summary>
        [JsonProperty("cardholder_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder_details")]
#endif
        public IssuingAuthorizationEvaluationCardholderDetailsOptions CardholderDetails { get; set; }

        /// <summary>
        /// Details about the merchant where the authorization occurred.
        /// </summary>
        [JsonProperty("merchant_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_details")]
#endif
        public IssuingAuthorizationEvaluationMerchantDetailsOptions MerchantDetails { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
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
        /// Details about the card network processing.
        /// </summary>
        [JsonProperty("network_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_details")]
#endif
        public IssuingAuthorizationEvaluationNetworkDetailsOptions NetworkDetails { get; set; }

        /// <summary>
        /// Details about the token, if a tokenized payment method was used.
        /// </summary>
        [JsonProperty("token_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_details")]
#endif
        public IssuingAuthorizationEvaluationTokenDetailsOptions TokenDetails { get; set; }

        /// <summary>
        /// Details about verification checks performed.
        /// </summary>
        [JsonProperty("verification_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_details")]
#endif
        public IssuingAuthorizationEvaluationVerificationDetailsOptions VerificationDetails { get; set; }
    }
}
