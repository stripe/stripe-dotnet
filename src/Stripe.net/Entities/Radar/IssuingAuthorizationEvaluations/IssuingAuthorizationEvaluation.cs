// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Authorization Evaluations represent fraud risk assessments for Issuing card
    /// authorizations. They include fraud risk signals and contextual details about the
    /// authorization.
    /// </summary>
    public class IssuingAuthorizationEvaluation : StripeEntity<IssuingAuthorizationEvaluation>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Details about the authorization.
        /// </summary>
        [JsonProperty("authorization_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_details")]
#endif
        public IssuingAuthorizationEvaluationAuthorizationDetails AuthorizationDetails { get; set; }

        /// <summary>
        /// Details about the card used in the authorization.
        /// </summary>
        [JsonProperty("card_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_details")]
#endif
        public IssuingAuthorizationEvaluationCardDetails CardDetails { get; set; }

        /// <summary>
        /// Details about the cardholder.
        /// </summary>
        [JsonProperty("cardholder_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder_details")]
#endif
        public IssuingAuthorizationEvaluationCardholderDetails CardholderDetails { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_details")]
#endif
        public IssuingAuthorizationEvaluationMerchantDetails MerchantDetails { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_details")]
#endif
        public IssuingAuthorizationEvaluationNetworkDetails NetworkDetails { get; set; }

        /// <summary>
        /// Collection of fraud risk signals for this authorization evaluation.
        /// </summary>
        [JsonProperty("signals")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("signals")]
#endif
        public IssuingAuthorizationEvaluationSignals Signals { get; set; }

        /// <summary>
        /// Details about the token, if a tokenized payment method was used for the authorization.
        /// </summary>
        [JsonProperty("token_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_details")]
#endif
        public IssuingAuthorizationEvaluationTokenDetails TokenDetails { get; set; }

        /// <summary>
        /// Details about verification data for the authorization.
        /// </summary>
        [JsonProperty("verification_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_details")]
#endif
        public IssuingAuthorizationEvaluationVerificationDetails VerificationDetails { get; set; }
    }
}
