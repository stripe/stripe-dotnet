// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Authorization Evaluations represent fraud risk assessments for Issuing card
    /// authorizations. They include fraud risk signals and contextual details about the
    /// authorization.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuingAuthorizationEvaluation : StripeEntity<IssuingAuthorizationEvaluation>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Details about the authorization.
        /// </summary>
        [JsonProperty("authorization_details")]
        [STJS.JsonPropertyName("authorization_details")]
        public IssuingAuthorizationEvaluationAuthorizationDetails AuthorizationDetails { get; set; }

        /// <summary>
        /// Details about the card used in the authorization.
        /// </summary>
        [JsonProperty("card_details")]
        [STJS.JsonPropertyName("card_details")]
        public IssuingAuthorizationEvaluationCardDetails CardDetails { get; set; }

        /// <summary>
        /// Details about the cardholder.
        /// </summary>
        [JsonProperty("cardholder_details")]
        [STJS.JsonPropertyName("cardholder_details")]
        public IssuingAuthorizationEvaluationCardholderDetails CardholderDetails { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Details about the seller (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_details")]
        [STJS.JsonPropertyName("merchant_details")]
        public IssuingAuthorizationEvaluationMerchantDetails MerchantDetails { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the authorization, such as identifiers, set by the card network.
        /// </summary>
        [JsonProperty("network_details")]
        [STJS.JsonPropertyName("network_details")]
        public IssuingAuthorizationEvaluationNetworkDetails NetworkDetails { get; set; }

        /// <summary>
        /// Collection of fraud risk signals for this authorization evaluation.
        /// </summary>
        [JsonProperty("signals")]
        [STJS.JsonPropertyName("signals")]
        public IssuingAuthorizationEvaluationSignals Signals { get; set; }

        /// <summary>
        /// Details about the token, if a tokenized payment method was used for the authorization.
        /// </summary>
        [JsonProperty("token_details")]
        [STJS.JsonPropertyName("token_details")]
        public IssuingAuthorizationEvaluationTokenDetails TokenDetails { get; set; }

        /// <summary>
        /// Details about verification data for the authorization.
        /// </summary>
        [JsonProperty("verification_details")]
        [STJS.JsonPropertyName("verification_details")]
        public IssuingAuthorizationEvaluationVerificationDetails VerificationDetails { get; set; }
    }
}
